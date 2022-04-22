using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsPassed = int.Parse(Console.ReadLine());
            Queue<string> carList = new Queue<string>();
            int count = 0;

            while (true)
            {
                string cars = Console.ReadLine();

                if (cars == "end")
                {
                    break;
                }
                if (cars == "green")
                {
                    if (carList.Count < carsPassed)
                    {
                        carsPassed = carList.Count;
                    }
                    for (int i = 0; i < carsPassed; i++)
                    {
                        Console.WriteLine($"{carList.Dequeue()} passed!");
                        count++;
                    }
                    continue;
                }
                carList.Enqueue(cars);
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
