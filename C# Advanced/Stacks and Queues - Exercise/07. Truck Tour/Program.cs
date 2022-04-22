using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            int index = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] pump = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(pump);
            }

            while (true)
            {
                int[] currPump = pumps.Dequeue();
                int fuel = currPump[0];
                int distance = currPump[1];
                pumps.Enqueue(currPump);
                Queue<int[]> tempPumps = new Queue<int[]>(pumps);

                if (fuel >= distance)
                {
                    fuel -= distance;

                    while (true)
                    {
                        int[] nextPump = tempPumps.Dequeue();
                        int nextFuel = nextPump[0];
                        int nextDistance = nextPump[1];
                        fuel += nextFuel;

                        if (nextPump == currPump)
                        {
                            Console.WriteLine(index);
                            return;
                        }
                        if (fuel >= nextDistance)
                        {
                            fuel -= nextDistance;
                            continue;
                        }
                        break;
                    }
                }
                index++;
            }
        }
    }
}
