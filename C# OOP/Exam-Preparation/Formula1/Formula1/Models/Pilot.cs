namespace Formula1.Models
{
    using Formula1.Models.Contracts;
    using Formula1.Utilities;
    using System;

    class Pilot : IPilot
    {
        private IFormulaOneCar car;
        private string fullName;

        public Pilot(string fullName)
        {
            this.FullName = fullName;
            this.CanRace = false;
            this.NumberOfWins = 0;
        }
        public string FullName
        {
            get => this.fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidPilot, value));
                }
                this.fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get => this.car;
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(
                        string.Format(ExceptionMessages.InvalidCarForPilot));
                }
                this.car = value;
            }
        }

        public int NumberOfWins { get; private set; }

        public bool CanRace { get; private set; }

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public override string ToString()
        {
            return $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
        }
    }
}
