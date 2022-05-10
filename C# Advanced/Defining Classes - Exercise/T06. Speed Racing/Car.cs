using System;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double travelledDistance = 0;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionFor1km;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelConsumptionPerKm
        {
            get { return fuelConsumptionPerKm; }
            set { fuelConsumptionPerKm = value; }
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public void Drive(double distance)
        {
            var totalConsumption = distance * this.fuelConsumptionPerKm;
            if (this.fuelAmount >= totalConsumption)
            {
                this.travelledDistance += distance;
                this.fuelAmount -= totalConsumption;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
