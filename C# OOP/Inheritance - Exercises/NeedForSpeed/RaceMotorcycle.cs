using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            this.FuelConsumption = 8;
        }

        public override double FuelConsumption { get ; set ; }
    }
}
