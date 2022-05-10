using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main() // !!!!!!!!
        {
          var numberOgCars = int.Parse(Console.ReadLine());
            var carsList = new List<Car>();

            for (int i = 0; i < numberOgCars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var tire1Press = double.Parse(carInfo[5]);
                var tire1Age = int.Parse(carInfo[6]);
                var tire2Press = double.Parse(carInfo[7]);
                var tire2Age = int.Parse(carInfo[8]);
                var tire3Press = double.Parse(carInfo[9]);
                var tire3Age = int.Parse(carInfo[10]);
                var tire4Press = double.Parse(carInfo[11]);
                var tire4Age = int.Parse(carInfo[12]);

                carsList.Add(new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                    tire1Press, tire1Age, tire2Press, tire2Age, tire3Press, tire3Age, tire4Press, tire4Age));
            }

            var outLine = Console.ReadLine();

            if (outLine == "fragile")
            {
                foreach (var car in carsList.Where(x => x.Cargo.Type == "fragile" 
                && x.Tires.Any(x => x.Pressure < 1)))   // Variant 1
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (outLine == "flammable")
            {
                foreach (var car in carsList)    // Variant 2
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
