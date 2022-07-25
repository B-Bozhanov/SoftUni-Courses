namespace Gym.Core
{
    using Gym.Core.Contracts;
    using Gym.Models.Athletes;
    using Gym.Models.Athletes.Contracts;
    using Gym.Models.Equipment;
    using Gym.Models.Equipment.Contracts;
    using Gym.Models.Gyms;
    using Gym.Models.Gyms.Contracts;
    using Gym.Repositories;
    using Gym.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private IRepository<IEquipment> equipments;
        private ICollection<IGym> gyms;

        public Controller()
        {
            this.equipments = new EquipmentRepository();
            this.gyms = new List<IGym>();
        }


        public string AddGym(string gymType, string gymName)
        {
            IGym gym;

            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }

            this.gyms.Add(gym);
            return $"Successfully added {gymType}.";
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment;

            if (equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();
            }
            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }

            this.equipments.Add(equipment);
            return $"Successfully added {equipmentType}.";
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment equipment = this.equipments.FindByType(equipmentType);
            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName);

            if (equipment == null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }

            this.equipments.Remove(equipment);
            gym.AddEquipment(equipment);
            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete;
            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            bool isBoxer = false;

            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
                isBoxer = true;
            }
            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
            }
            else
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }

            if (gym is BoxingGym && !isBoxer)
            {
                return "The gym is not appropriate.";
            }
            else if (gym is WeightliftingGym && isBoxer)
            {
                return "The gym is not appropriate.";
            }
            else
            {
                gym.AddAthlete(athlete);
                return $"Successfully added {athleteType} to {gymName}.";
            }
        }

        public string EquipmentWeight(string gymName)
        {
            var gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            return $"The total weight of the equipment in the gym {gymName} is {gym.EquipmentWeight:f2} grams.";
        }
        public string TrainAthletes(string gymName)
        {
            var gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            gym.Exercise();
            return $"Exercise athletes: {gym.Athletes.Count}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in gyms)
            {
               sb.AppendLine(gym.GymInfo());
            }

            return sb.ToString().Trim();
        }

    }
}
