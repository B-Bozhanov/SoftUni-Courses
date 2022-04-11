using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startIndex = -1;
            Queue<int> pumps = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(input[0]);
                pumps.Enqueue(input[1]);
            }

            Queue<int> currentPumps = new Queue<int>(pumps);
            int leftFuel = 0;
            while (true)
            {
                int fuel = currentPumps.Dequeue();
                int distance = currentPumps.Dequeue();
                leftFuel += fuel;

                if (leftFuel < distance)
                {
                    currentPumps.Enqueue(fuel);
                    currentPumps.Enqueue(distance);
                    startIndex++;
                    continue;
                }

                while (true)
                {
                    leftFuel -= distance;
                    int currFuel = currentPumps.Dequeue();
                    int currDistance = currentPumps.Dequeue();

                    if (leftFuel < distance)
                    {
                        currentPumps.Enqueue(currFuel);
                        currentPumps.Enqueue(currDistance);
                        startIndex++;
                        break;
                    }
                    else if (true)
                    {

                    }
                }
            }
        }
    }
}
// 1 5
// 10 4
// 3 4
