namespace Vehicles.Models
{
    using Vehicles.Models.Interfaces;

    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double littersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = littersPerKm;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }

        public string Drive(double distance)
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
            this.FuelQuantity += fuelAmount;
        }
    }
}
