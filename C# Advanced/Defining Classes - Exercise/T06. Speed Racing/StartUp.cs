using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var carsList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var consumptionPerKm = double.Parse(carInfo[2]);

                if (!carsList.Any(x => x.Model == model))
                {
                    carsList.Add(new Car(model, fuelAmount, consumptionPerKm));
                }
            }

            while (true)
            {
                var commands = Console.ReadLine();
                if (commands == "End")
                {
                    break;
                }

                var cmdArgs = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var drive = cmdArgs[0];
                var car = cmdArgs[1];
                var distance = double.Parse(cmdArgs[2]);

                var currentCar = carsList.FirstOrDefault(x => x.Model == car);

                if (drive == "Drive")
                {
                    currentCar.Drive(distance);
                }
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
