using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int push = commands[0];
            int pop = commands[1];
            int seekNum = commands[2];

            Stack<int> numbers = new Stack<int>();
            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            for (int i = 0; i < push; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (!numbers.Contains(seekNum))
            {
                int smallestNum = numbers.Min();
                Console.WriteLine(smallestNum);
                return;
            }

            Console.WriteLine("true");
        }
    }
}