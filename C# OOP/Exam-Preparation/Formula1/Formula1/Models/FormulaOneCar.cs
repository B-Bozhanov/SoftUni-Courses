namespace Formula1.Models
{
    using System;
    using Formula1.Models.Contracts;
    using Formula1.Utilities;

    public abstract class FormulaOneCar : IFormulaOneCar, ICar
    {
        private string type;
        private string model;
        private int horsePower;
        private double engineDisplacement;


        public FormulaOneCar(string type, string model, int horsePower, double engineDisplacement)
        {
            this.CarType = type;
            this.Model = model;
            this.Horsepower = horsePower;
            this.EngineDisplacement = engineDisplacement;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidF1CarModel, value));
                }
                this.model = value;
            }
        }

        public int Horsepower
        {
            get => this.horsePower;
            private set
            {
                if (value < 900 || value > 1050)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidF1HorsePower, value));
                }
                this.horsePower = value;
            }
        }

        public double EngineDisplacement
        {
            get => this.engineDisplacement;
            private set
            {
                if (value < 1.6 || value > 2.00)
                {
                    throw new ArgumentNullException(
                        string.Format(ExceptionMessages.InvalidF1EngineDisplacement, value));
                }
                this.engineDisplacement = value;
            }
        }

        public string CarType
        {
            get => this.type;
            private set
            {
                if (this.type != "Ferrary" && this.type != "Williams")
                {
                    throw new InvalidOperationException(
                        string.Format(ExceptionMessages.InvalidTypeCar, value));
                }
                this.type = value;
            }
        }

        public double RaceScoreCalculator(int laps) => this.EngineDisplacement / this.Horsepower * laps;
    }
}
