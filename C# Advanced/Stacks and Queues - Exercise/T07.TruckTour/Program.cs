using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> pumps = new Queue<int[]>();
            int numOfPumps = int.Parse(Console.ReadLine());

            // Read the input!
            for (int pump = 0; pump < numOfPumps; pump++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();

                pumps.Enqueue(input);
            }
            int tank = 0;
            while (true)
            {
                int[] currentPump = pumps.Peek();
                int fuel = currentPump[0];
                int distance = currentPump[1];
                tank += fuel;

                if (tank < distance)
                {
                    pumps.Enqueue(pumps.Dequeue());
                   // tank -= fuel;
                    continue;
                }

            }
        }
    }
}

