using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {[()]} -This is a balanced parenthesis.
            // {}[]() - This is a balanced parenthesis.
            // {[(])} -This is not a balanced parenthesis.
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool IsMatch = true;


            foreach (var item in input)
            {
                if (item == '[' || item == '{' || item == '(')
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        IsMatch = false;
                        break;
                    }
                    if (item == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if (item == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (item == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        IsMatch = false;
                        break;  // {[{{{{{{{{{{{{[[[()()(()()(()()()()()()()()()() Do not work without break!
                    }
                }
            }
            if (!IsMatch || stack.Count != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
