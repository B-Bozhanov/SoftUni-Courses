namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumptionPerKm { get;}
        public double TankCapacity { get; }
        public bool IsEmptyVehicle { get; set; }

        public string Drive(double distance);
        public void Refuel(double fuelAmount);
        public IVehicle GetInstance();
    }
}
