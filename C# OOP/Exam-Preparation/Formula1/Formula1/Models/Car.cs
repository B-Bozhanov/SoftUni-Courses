using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;

namespace Formula1.Models
{
    public class Car : FormulaOneCar
    {
        public Car(string type, string model, int horsePower, double engineDisplacement) 
            : base(type, model, horsePower, engineDisplacement)
        {
        }
    }
}
