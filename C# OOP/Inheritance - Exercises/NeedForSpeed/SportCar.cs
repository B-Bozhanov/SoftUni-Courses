using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.FuelConsumption = 10;
        }

        public override double FuelConsumption { get ; set ; }
    }
}
