using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Stack<string> numbers = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                numbers.Push(input[i]);
            }

            while (numbers.Count != 1)
            {
                int firstNumeber = int.Parse(numbers.Pop());
                string action = numbers.Pop();
                int secondNumeber = int.Parse(numbers.Pop());

                if (action == "+")
                {
                    numbers.Push((firstNumeber + secondNumeber).ToString());
                }
                else if (action == "-")
                {
                    numbers.Push((firstNumeber - secondNumeber).ToString());
                }
            }
            Console.WriteLine(string.Join("", numbers));
        }
    }
}
