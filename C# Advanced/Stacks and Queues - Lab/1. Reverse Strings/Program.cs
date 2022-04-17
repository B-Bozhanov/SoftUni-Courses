using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);

            //foreach (var item in input)
            //{
            //    stack.Push(item);
            //}
            foreach (var item in stack)
            {
                Console.Write(item);
            }
            //while (stack.Any())
            //{
            //    Console.Write(stack.Pop());
            //}
        }
    }
}

