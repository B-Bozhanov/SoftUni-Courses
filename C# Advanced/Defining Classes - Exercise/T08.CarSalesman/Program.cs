using System;
using System.Collections.Generic;
using System.Linq;

namespace T08.CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engines = new List<Engine>();
            var cars = new List<Car>(); 

            var numOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                AddEngine(engines, engineInfo);
            }

            var numOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                AddCar(cars, engines, carInfo);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static bool IsDigit(string input)
        {
            foreach (var ch in input)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        private static void AddEngine(List<Engine> engines, string[] engineInfo)
        {
            var engineModel = engineInfo[0];
            var enginePower = int.Parse(engineInfo[1]);

            if (engineInfo.Length == 4)
            {
                var displacementl = int.Parse(engineInfo[2]);
                var efficiency = engineInfo[3];
                engines.Add(new Engine(engineModel, enginePower, displacementl, efficiency));
            }
            else if (engineInfo.Length == 3)
            {
                if (IsDigit(engineInfo[2]))
                {
                    var displacementl = int.Parse(engineInfo[2]);
                    engines.Add(new Engine(engineModel, enginePower, displacementl));
                }
                else
                {
                    var efficiency = engineInfo[2];
                    engines.Add(new Engine(engineModel, enginePower, efficiency));
                }
            }
            else
            {
                engines.Add(new Engine(engineModel, enginePower));
            }
        }
        private static void AddCar(List<Car> cars,List<Engine> engines, string[] carInfo)
        {
            var carModel = carInfo[0];
            var engineModel = carInfo[1];
            var currEngine = engines.FirstOrDefault(x => x.Model == engineModel);

            if (carInfo.Length == 4)
            {
                var weight = int.Parse(carInfo[2]);
                var color = carInfo[3];
                cars.Add(new Car(carModel, currEngine, weight, color));
            }
            else if (carInfo.Length == 3)
            {
                if (IsDigit(carInfo[2]))
                {
                    var weight = int.Parse(carInfo[2]);
                    cars.Add(new Car(carModel, currEngine, weight));
                }
                else
                {
                    var color = carInfo[2];
                    cars.Add(new Car(carModel, currEngine, color));
                }
            }
            else
            {
                cars.Add(new Car(carModel, currEngine));
            }
        }
    }
}
