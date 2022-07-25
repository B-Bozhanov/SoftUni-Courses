using System;
using System.Linq;
using System.Collections.Generic;

using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System.Text;
using System.Linq;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private readonly List<IEquipment> equipment;
        private readonly List<IAthlete> athletes;

        private Gym()
        {
            this.equipment = new List<IEquipment>();
            this.athletes = new List<IAthlete>();
        }
        public Gym(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public double EquipmentWeight { get => this.equipment.Sum(x => x.Weight); }

        public ICollection<IEquipment> Equipment { get => this.equipment; }

        public ICollection<IAthlete> Athletes { get => this.athletes; }



        public void AddAthlete(IAthlete athlete)
        {
            if (this.athletes.Count + 1 > this.Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }

            this.athletes.Add(athlete);
        }
        public bool RemoveAthlete(IAthlete athlete)
        {
            return this.athletes.Remove(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }

        public void Exercise()
        {
            this.athletes.ForEach(x => x.Exercise());
        }

        public string GymInfo()
        {
            StringBuilder gymInfo = new StringBuilder();
            gymInfo.AppendLine($"{this.Name} is a {GetType().Name}:");
            if (this.athletes.Count == 0)
            {
                gymInfo.AppendLine($"Athletes: No athletes");
            }
            else
            {
                gymInfo.Append($"Athletes: ");
                foreach (var athlete in this.athletes)
                {
                    gymInfo.Append($"{athlete.FullName}, ");
                }
                gymInfo.AppendLine();
            }
            gymInfo.AppendLine($"Equipment total count: {this.equipment.Count}");
            gymInfo.AppendLine($"Equipment total weight: {this.EquipmentWeight:f2} grams");

            return gymInfo.ToString().Trim();
        }

    }
}
