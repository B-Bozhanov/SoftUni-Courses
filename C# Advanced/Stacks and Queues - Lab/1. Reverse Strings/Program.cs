using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Linq;
>>>>>>> 127ee2508096684beced58ffbbca6630d5b46910

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
<<<<<<< HEAD

            Stack<char> stack = new Stack<char>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            foreach (var item in stack)
            {
                Console.Write(item);
=======
            Stack<char> stack = new Stack<char>(input);

            //foreach (var ch in stack)
            //{
            //    Console.Write(ch);
            //}
            while (stack.Any())
            {
                Console.Write(stack.Pop());
>>>>>>> 127ee2508096684beced58ffbbca6630d5b46910
            }
        }
    }
}
