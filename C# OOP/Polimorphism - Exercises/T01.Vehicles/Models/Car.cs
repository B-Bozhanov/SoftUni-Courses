using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double DefaultIncreesedConsuption = 0.9;

        public Car(double fuelQuantity, double littersPerKm, double tankCapacity) 
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
            IVehicle car = new Car(this.FuelQuantity,
              this.FuelConsumptionPerKm, this.TankCapacity);
            return car;
        }

        //public override IVehicle GetInstance 
        //{
        //    get 
        //    {
        //        return new Car(this.FuelQuantity, 
        //            this.FuelConsumptionPerKm, this.TankCapacity); 
        //    } 
        //}
    }
}
