using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Expresion
{
    class Program
    {
        static void Main(string[] args)
        {
            var expresion = "((10 - 5 + 3)*2)/2";
            var result = Solution(expresion);
            Console.WriteLine(result);
        }

        private static double Solution(string expresion)
        {
            var numbers = new Stack<double>();
            var operators = new Stack<char>();
            string validOperators = "+-*/";
            //TODO: Check for Valid expresion!

            for (int i = 0; i < expresion.Length; i++)
            {
                var ch = expresion[i];

                if (ch == '(')
                {
                    operators.Push(ch);
                }
                else if (ch == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        var num2 = numbers.Pop();
                        var num1 = numbers.Pop();
                        var operat = operators.Pop();
                    }
                }
                else if (validOperators.Contains(ch))
                {
                    operators.Push(ch);
                }
                else if (Char.IsDigit(ch))
                {
                    var number = new StringBuilder();

                    while (Char.IsDigit(ch) || ch == '.')
                    {
                        number.Append(ch);

                        i++;                  // continue with For loop in While loop
                        ch = expresion[i];
                    }
                    i--;                      // To not lose the last operator after the digits.

                    numbers.Push(double.Parse(number.ToString()));
                }
            }
            return 0.0;
        }
    }
}
