namespace Vehicles.Models
{
    using System;
    using Vehicles.Models.Interfaces;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double littersPerKm, double tankCapacity)
        {
            this.IsEmptyVehicle = true;
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = littersPerKm;
        }

        public double FuelQuantity 
        {
            get => this.fuelQuantity; 
            private set
            {
                if (value > this.TankCapacity)
                {
                    throw new ArgumentException($"Cannot fit {this.FuelQuantity } fuel in the tank");
                }
                this.fuelQuantity = value;
            } 
        }

        public virtual double FuelConsumptionPerKm { get; protected set; }

        public double TankCapacity { get; private set; }

        public bool IsEmptyVehicle { get; set; }
       // public abstract IVehicle GetInstance { get;} 


        public virtual string Drive(double distance)
        {
            var neededFuel = this.FuelConsumptionPerKm * distance;
            if (neededFuel > this.FuelQuantity )
            {
                return $"{GetType().Name } needs refueling";
            }

            this.FuelQuantity -= neededFuel;

            return $"{GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuelAmount;
        }

        public abstract IVehicle GetInstance();
    }
}
