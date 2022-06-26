using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.FuelConsumption = 3;
        }

        public override double FuelConsumption { get; set; }
    }
}
