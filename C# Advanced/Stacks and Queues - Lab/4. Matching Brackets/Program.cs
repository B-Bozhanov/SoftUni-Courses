using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int lastOpenBracket = brackets.Pop();
                    string currentResult = input.Substring(lastOpenBracket, i + 1 - lastOpenBracket); // Also may be with For loop (from lastOpenBracket to i!)
                    Console.WriteLine(currentResult);
                }
            }
        }
    }
}
