using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.Type = cargoType;
            this.Weight = cargoWeight;
        }
    }
}
