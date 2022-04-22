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
           int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int searchedNum = input[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            if (stack.Contains(searchedNum))
            {
                Console.WriteLine("true");
                return;
            }
            Console.WriteLine(stack.Min());
        }
    }
}
