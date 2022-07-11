namespace Formula1.Core
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Formula1.Models;
    using Formula1.Models.Contracts;
    using Formula1.Repositories;
    using Formula1.Utilities;
    using Formula1.Core.Contracts;

    public class Controller : IController
    {
        private readonly PilotRepository pilotRepository;
        private readonly RaceRepository raceRepository;
        private readonly FormulaOneCarRepository carRepository;

        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            carRepository = new FormulaOneCarRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot pilot = pilotRepository.FindByName(pilotName);
            IFormulaOneCar car = carRepository.FindByName(carModel);

            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));
            }

            if (carRepository.Remove(car))
            {
                pilot.AddCar(car);
                return string.Format(OutputMessages.SuccessfullyPilotToCar, pilot.FullName, car.GetType().Name, car.Model);
            }

            throw new NullReferenceException(
                    string.Format(ExceptionMessages.CarDoesNotExistErrorMessage, carModel));

        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IPilot pilot = pilotRepository.FindByName(pilotFullName);
            IRace race = raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            if (pilot == null || pilot.CanRace == false
                || race.Pilots.Any(p => p.FullName == pilotFullName)) // May be not to compare the names of pilot
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }

            race.Pilots.Add(pilot);
            return $"Pilot {pilot.FullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            IFormulaOneCar car;

            if (carRepository.FindByName(model) != null)
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.CarExistErrorMessage, model));
            }

            if (type == "Ferrari")
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
            }
            else if (type == "Williams")
            {
                car = new Williams(model, horsepower, engineDisplacement);
            }
            else
            {
                throw new InvalidOperationException($"Formula one car type {type} is not valid.");
            }


            carRepository.Add(car);
            return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);
        }

        public string CreatePilot(string fullName)
        {
            IPilot pilot = new Pilot(fullName);

            if (pilotRepository.FindByName(pilot.FullName) != null)
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }

            pilotRepository.Add(pilot);
            return string.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            IRace race = new Race(raceName, numberOfLaps);

            if (raceRepository.FindByName(race.RaceName) != null)
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }

            raceRepository.Add(race);
            return string.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string PilotReport()
        {
            var pilots = new StringBuilder();

            foreach (var pilot in pilotRepository.Models.OrderByDescending(x => x.NumberOfWins))
            {
                pilots.AppendLine(pilot.ToString());
            }

            return pilots.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            var races = new StringBuilder();
            foreach (var race in raceRepository.Models)
            {
                if (race.TookPlace)
                {
                    races.AppendLine(race.RaceInfo());
                }
            }

            return races.ToString().TrimEnd();
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than three participants.");
            }

            if (race.TookPlace)
            {
                throw new InvalidOperationException($"Can not execute race {raceName}.");
            }

            List<IPilot> final = race.Pilots.OrderByDescending(p => p.Car.RaceScoreCalculator(race.NumberOfLaps)).ToList();


            final[0].WinRace();
            race.TookPlace = true;

            var finalists = new StringBuilder();

            finalists.AppendLine($"Pilot {final[0].FullName} wins the {raceName} race.");
            finalists.AppendLine($"Pilot {final[1].FullName} is second in the {raceName} race.");
            finalists.AppendLine($"Pilot {final[2].FullName} is third in the {raceName} race.");

            return finalists.ToString().TrimEnd();
        }
    }
}
