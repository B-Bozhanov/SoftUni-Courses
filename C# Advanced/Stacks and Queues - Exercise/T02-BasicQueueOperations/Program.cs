using System;
using System.Collections.Generic;
using System.Linq;

namespace T02_BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }

        }
    }
}
