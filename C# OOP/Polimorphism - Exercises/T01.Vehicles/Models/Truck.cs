namespace Vehicles.Models
{
    class Truck : Vehicle
    {
        private const double DefaultIncreesedConsuption = 1.6;
        public Truck(double fuelQuantity, double littersPerKm)
            : base(fuelQuantity, littersPerKm + DefaultIncreesedConsuption)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * 0.95);
        }
    }
}
