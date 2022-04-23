using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var greenLightTime = int.Parse(Console.ReadLine());
            var timeToExit = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();
            var passedCars = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
                    break;
                }
                if (input == "green")
                {
                    var currGreenTime = greenLightTime;
                    var currTimeToExit = timeToExit;
                    while (true)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        if (currGreenTime <= 0)
                        {
                            break;
                        }
                        var carElements = cars.Peek().Length;
                        var currentCar = cars.Peek();

                        if (currGreenTime < carElements)
                        {
                            carElements -= currGreenTime;
                            currGreenTime = 0;
                            carElements -= currTimeToExit;
                            if (carElements <= 0)
                            {
                                cars.Dequeue();
                                passedCars++;
                                continue;
                            }
                            var crashedPart = currentCar.Length - carElements;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[crashedPart]}.");
                            return;
                        }

                        currGreenTime -= carElements;
                        if (currGreenTime <= 0)
                        {
                            currGreenTime = 0;
                        }
                        cars.Dequeue();
                        passedCars++;
                    }
                    continue;
                }

                cars.Enqueue(input);
            }
        }
    }
}
