using System;

namespace _03._Need_for_Speed_III
{
    class Cars
    {
        public string Car { get; set; }
        public int Milleage { get; set; }
        public int Fuel { get; set; }
        private int maxMileage = 100000;
        private int maxLitters = 75;

        public Cars(string car, int milleage, int fuel)
        {
            this.Car = car;
            this.Milleage = milleage;
            this.Fuel = fuel;
        }

        public bool Drive(int distanceToDrive, int neededFuel)
        {
            bool isMileageOver = false;
            if (Fuel < neededFuel)                           // Check if the fuel will be enough to drive the distance.
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return isMileageOver;
            }
            Milleage += distanceToDrive;
            Fuel -= neededFuel;

            Console.WriteLine($"{Car} driven for {distanceToDrive} kilometers. {neededFuel} liters of fuel consumed.");
            if (Milleage >= maxMileage)                    // Check if the mileages are greater or equal to 100 000, and if is true - remove current car 
            {
                Console.WriteLine($"Time to sell the {Car}!");
                isMileageOver = true;
            }

            return isMileageOver;
        }

        public void Refuel(int refuel)
        {
            if (Fuel + refuel > maxLitters)
            {
                refuel = maxLitters - Fuel;            // Take how fuel is needed to fill 75 liters tank, if it's greater than 75.
                Fuel = maxLitters;
            }
            else
            {
                Fuel += refuel;
            }
            Console.WriteLine($"{Car} refueled with {refuel} liters");
        }

        public void Revert(int mileageToDecreese)
        {
            Milleage -= mileageToDecreese;
            if (Milleage < 10000)
            {
                Milleage = 10000;                     // Rewrite mileages to 10 000 if it's  less than after Revert command.
            }
                Console.WriteLine($"{Car} mileage decreased by {mileageToDecreese} kilometers");
        }
    }
}
