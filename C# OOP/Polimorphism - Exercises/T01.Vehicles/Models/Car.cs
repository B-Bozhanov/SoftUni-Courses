namespace Vehicles.Models
{
    using Vehicles.Models.Interfaces;

    public class Car : Vehicle
    {
        private const double DefaultIncreesedConsuption = 0.9;

        public Car(double fuelQuantity, double littersPerKm) 
            : base(fuelQuantity, littersPerKm + DefaultIncreesedConsuption)
        {
        }
    }
}
