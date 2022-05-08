using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tires = new List<List<Tire>>();
            var engines = new List<Engine>();
            var cars = new List<Car>();
            var count = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }

                var inputArgs = input.Split().Select(double.Parse).ToArray();

                tires.Add(new List<Tire>());

                for (int i = 0; i < inputArgs.Length - 1; i += 2)
                {
                    tires[count].Add(new Tire((int)inputArgs[i], inputArgs[i + 1]));
                }
                count++;
            }

            while (true)
            {
                var engineInput = Console.ReadLine();
                if (engineInput == "Engines done")
                {
                    break;
                }

                var inputArgs = engineInput.Split().Select(double.Parse).ToArray();
                var horsePower = inputArgs[0];
                var cubics = inputArgs[1];

                engines.Add(new Engine((int)horsePower, cubics));
            }

            while (true)
            {
                var car = Console.ReadLine();
                if (car == "Show special")
                {
                    break;
                }
                var carArgs = car.Split();
                var make = carArgs[0];
                var model = carArgs[1];
                var year = int.Parse(carArgs[2]);
                var capacity = double.Parse(carArgs[3]);
                var litters = double.Parse(carArgs[4]);
                var engineIndex = int.Parse(carArgs[5]);
                var tireIndex = int.Parse(carArgs[6]);

                cars.Add(new Car(make, model, year, capacity, litters, engines[engineIndex], tires[tireIndex].ToArray()));
            }

            foreach (var car in cars)
            {
                var pressureSum = car.Tire.Sum(x => x.Pressure);

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 &&
                    pressureSum >= 9 && pressureSum <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
