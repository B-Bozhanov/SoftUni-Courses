using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using Formula1.Repositories.Contracts;
using Formula1.Utilities;
using System.Linq;
using System;

namespace Formula1.Core.Contracts
{
    class Controler : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository  raceRepository ;
        private FormulaOneCarRepository carRepository ;
        private IPilot pilot;
        private IRace race;
        private IFormulaOneCar car;


        public Controler()
        {
            this.pilotRepository = new PilotRepository();
            this.raceRepository = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            this.pilot = this.pilotRepository.Models.FirstOrDefault(p => p.FullName == pilotName);
            this.car = this.carRepository.Models.FirstOrDefault(c => c.Model == carModel);

            if (this.pilot == null || this.pilot.Car != null)
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));
            }
            if (this.car == null)
            {
                throw new NullReferenceException(
                    string.Format(ExceptionMessages.CarDoesNotExistErrorMessage, nameof(carModel)));
            }
            
            this.pilot.AddCar(this.car);
            return string.Format(OutputMessages.SuccessfullyPilotToCar, this.pilot.FullName, this.car.);
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            throw new System.NotImplementedException();
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            this.car = new Car(type, model, horsepower, engineDisplacement);

            if (this.carRepository.Models.Any(c => c.Model == model))
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.CarExistErrorMessage, model));
            }

            this.carRepository.Add(this.car);
            return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);
        }

        public string CreatePilot(string fullName)
        {
            this.pilot = new Pilot(fullName);

            if (this.pilotRepository.Models.Any(p => p.FullName == fullName))
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }

            this.pilotRepository.Add(this.pilot);
            return string.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            this.race = new Race(raceName, numberOfLaps);

            if (this.raceRepository.Models.Any(r => r.RaceName == raceName))
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }

            this.raceRepository.Add(this.race);
            return string.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string PilotReport()
        {
            throw new System.NotImplementedException();
        }

        public string RaceReport()
        {
            throw new System.NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new System.NotImplementedException();
        }
    }
}
