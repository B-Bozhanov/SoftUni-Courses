using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    public class Result
    {
        public bool IsBalanced(string brackets)
        {
            // (({[]}))
            char[] validTypes = new char[] { '(', ')', '[', ']', '{', '}' };

            Stack<char> openBrackets = new Stack<char>();

            for (int i = 0; i < brackets.Length; i++)
            {
                if (!validTypes.Any(b => b == brackets[i]))
                {
                    throw new InvalidOperationException("Please insert valid brackets!");
                }
            }

            if (IsClosed(brackets[0]))
            {
                throw new InvalidOperationException("Expresion must begin with open bracket!");
            }
            //openBrackets.Push(brackets[0]);

            for (int i = 0; i < brackets.Length; i++)
            {
                if (!openBrackets.Any() && IsClosed(brackets[i]))
                {
                    throw new InvalidOperationException("Closed brackeds are more than open!");
                }

                if (openBrackets.Any())
                {
                    if (brackets[i] == ')' && openBrackets.Peek() == '(') // ()()(())()()
                    {
                        openBrackets.Pop();
                        continue;
                    }
                    else if (brackets[i] == ']' && openBrackets.Peek() == '[')
                    {
                        openBrackets.Pop();
                        continue;
                    }
                    else if (brackets[i] == '}' && openBrackets.Peek() == '{')
                    {
                        openBrackets.Pop();
                        continue;
                    }
                }

                openBrackets.Push(brackets[i]);
            }

            if (openBrackets.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsClosed(char bracked)
        {
            return bracked == ')' || bracked == ']' || bracked == ')';
        }
    }
}