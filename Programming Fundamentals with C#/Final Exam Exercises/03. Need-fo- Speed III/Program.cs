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
            Dictionary<string, int[]> carsInfo = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string car = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);
                if (!carsInfo.ContainsKey(car))
                {
                    carsInfo.Add(car, new int[2] { mileage, fuel });         // Add input info to  collection.
                }
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandArgs = command.Split(" : ");
                string action = commandArgs[0];
                string car = commandArgs[1];

                int carMileage = carsInfo[car][0];                       // Get mileage and start fuel from collection.
                int startFuel = carsInfo[car][1];

                if (action == "Drive")
                {
                    int distanceToDrive = int.Parse(commandArgs[2]);
                    int neededFuel = int.Parse(commandArgs[3]);

                    if (startFuel < neededFuel)                           // Check if the fuel will be enough to drive the distance.
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        carMileage += distanceToDrive;                   // Increase car mileage with the given distance
                        startFuel -= neededFuel;                         // Decrease car fuel with the given fuel.
                        carsInfo[car][0] = carMileage;                  // Rewrite new values in collection
                        carsInfo[car][1] = startFuel;

                        Console.WriteLine($"{car} driven for {distanceToDrive} kilometers. {neededFuel} liters of fuel consumed.");
                        if (carMileage >= 100000)                    // Check if the mileages are greater or equal to 100 000, and if is true - remove current car 
                                                                     // from collection.
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carsInfo.Remove(car);
                        }
                    }
                }
                else if (action == "Refuel")
                {
                    int refuel = int.Parse(commandArgs[2]);            
                    if (startFuel + refuel > 75)
                    {
                        refuel = 75 - startFuel;            // Take how fuel is needed to fill 75 liters tank, if it's greater than 75.
                        startFuel = 75;
                    }
                    else
                    {
                        startFuel += refuel;
                    }
                    carsInfo[car][1] = startFuel;
                    Console.WriteLine($"{car} refueled with {refuel} liters");
                }
                else if (action == "Revert")
                {
                    int mileageToDecreese = int.Parse(commandArgs[2]);
                    carMileage -= mileageToDecreese;
                    if (carMileage < 10000)
                    {
                        carMileage = 10000;                     // Rewrite mileages to 10 000 if it's  less than after Revert command.
                        carsInfo[car][0] = carMileage;
                    }
                    else
                    {
                        carsInfo[car][0] = carMileage;
                        Console.WriteLine($"{car} mileage decreased by {mileageToDecreese} kilometers");
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var item in carsInfo.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))  // Print collection.
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
