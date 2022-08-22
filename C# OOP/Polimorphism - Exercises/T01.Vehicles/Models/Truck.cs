using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    class Truck : Vehicle
    {
        private const double DefaultIncreesedConsuption = 1.6;
        public Truck(double fuelQuantity, double littersPerKm, double tankCapacity)
            : base(fuelQuantity, littersPerKm, tankCapacity)
        {
        }


        public override double FuelConsumptionPerKm
        {
            get => base.FuelConsumptionPerKm;
            protected set
            {
                base.FuelConsumptionPerKm = value + DefaultIncreesedConsuption;
            }
        }

        public override IVehicle GetInstance()
        {
            throw new System.NotImplementedException();
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * 0.95);
        }
    }
}
