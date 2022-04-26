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
                        //if (operators.Peek() == '-')
                        //{
                        //    num1 *= -1;
                        //}

                        numbers.Push(Calculation(operat, num1, num2));
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
        private static double Calculation(char ch, double num1, double num2)
        {
            switch (ch)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num1 / num2;
                default: return 0.0;
            }
        }
        private static int Prioriry(char ch)
        {
            switch (ch)
            {
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                default: return 0;
            }
        }
    }
}
