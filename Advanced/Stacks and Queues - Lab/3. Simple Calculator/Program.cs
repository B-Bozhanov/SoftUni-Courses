using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();

            Stack<string> numbers = new Stack<string>(input);

            for (int i = numbers.Count - 1; i >= 0; i++)
            {
                int first = int.Parse(numbers.Pop());
                string action = numbers.Pop();
                int second = int.Parse(numbers.Pop());

                if (action == "+")
                {
                    numbers.Push((first + second).ToString());
                }
                else if (action == "-")
                {
                    numbers.Push((Math.Abs(first - second)).ToString());
                }
                if (numbers.Count == 1)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join("", numbers));
        }
    }
}
