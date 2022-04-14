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

            //foreach (var ch in stack)
            //{
            //    Console.Write(ch);
            //}
            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
