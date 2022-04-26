using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> clothes = new Stack<int>(input);
            int rackCapacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int currentSum = 0;

            while (true)
            {
                if (clothes.Count == 0)
                {
                    Console.WriteLine(racks);
                    break;
                }
                currentSum += clothes.Pop();
                if (currentSum > rackCapacity || currentSum + clothes.Peek() > rackCapacity)
                {
                    racks++;
                    currentSum = 0;
                }
                if (clothes.Count == 1)
                {
                    racks++;
                    clothes.Pop();
                }
            }
        }
    }
}
