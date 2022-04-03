using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int num = input[1];
                    stack.Push(num);
                }
                if (stack.Count > 0)
                {
                    if (command == 2)
                    {
                        stack.Pop();
                    }
                    else if (command == 3)
                    {
                            Console.WriteLine(stack.Max());
                    }
                    else if (command == 4)
                    {
                            Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
