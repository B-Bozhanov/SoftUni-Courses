using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Cars> cars = new List<Cars>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                cars.Add(new Cars(car, mileage, fuel));
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string car = commandArgs[1];

                Cars currCar = cars.SingleOrDefault(x => x.Car == car);

                if (action == "Drive")
                {
                    int distanceToDrive = int.Parse(commandArgs[2]);
                    int neededFuel = int.Parse(commandArgs[3]);

                    if (currCar.Drive(distanceToDrive, neededFuel))
                    {
                        cars.Remove(currCar);
                    }
                }
                else if (action == "Refuel")
                {
                    int refuel = int.Parse(commandArgs[2]);
                    currCar.Refuel(refuel);
                }
                else if (action == "Revert")
                {
                    int mileageToDecreese = int.Parse(commandArgs[2]);
                    currCar.Revert(mileageToDecreese);
                }

                command = Console.ReadLine();
            }

            foreach (Cars car in cars.OrderByDescending(x => x.Milleage).ThenBy(x => x.Car))
            {
                Console.Write($"{car.Car} -> Mileage: {car.Milleage} km, Fuel in the tank: {car.Fuel} lt.");
                Console.WriteLine();
            }
        }
    }
}
