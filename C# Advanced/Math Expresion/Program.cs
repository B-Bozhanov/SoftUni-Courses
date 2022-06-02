using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Expresion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type expresion: (Press esc to Exit)");
                var expresion = Console.ReadLine();
                var result = Solution(expresion);
                Console.WriteLine($"Result: {result}");
            }

        }

        private static double Solution(string expresion)
        {
            var numbers = new Stack<double>();
            var operators = new Stack<char>();
            var unknowns = new Stack<double>();
            string validOperators = "+-*/^%";
            var openBracketCount = 0;
            var isEqualChar = false;
            //TODO: Check for Valid expresion!
            // 4x +30 -10 +2x = x + 10
            for (int i = 0; i < expresion.Length; i++)
            {
                var ch = expresion[i];

                if (ch == '(')
                {
                    operators.Push(ch);
                    openBracketCount++;
                }
                else if (ch == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        var num2 = numbers.Pop();
                        var num1 = numbers.Pop();
                        var operat = operators.Pop();
                        // 18-(3*3-4)
                        numbers.Push(Calculation(operat, num1, num2));
                    }
                    operators.Pop();  // (
                    openBracketCount--;
                }
                else if (validOperators.Contains(ch))
                {
                    while (operators.Count > 0 && Prioriry(operators.Peek()) >= Prioriry(ch))
                    {
                        if (operators.Count - openBracketCount + 1 > numbers.Count) // 1 is the current char
                        {
                            break;
                        }
                        var num2 = numbers.Pop();
                        var num1 = numbers.Pop();
                        var operat = operators.Pop();
                        numbers.Push(Calculation(operat, num1, num2));
                    }
                    operators.Push(ch);
                }
                else if (Char.IsDigit(ch))
                {
                    var number = new StringBuilder();

                    while (Char.IsDigit(ch) || ch == '.')
                    {
                        number.Append(ch);

                        i++;                  // continue with For loop in While loop
                        if (i == expresion.Length)
                        {
                            break;
                        }
                        ch = expresion[i];
                    }
                    i--;                      // To not lose the last operator after the digit.
                    var currentNum = double.Parse(number.ToString());

                    if (operators.Count - openBracketCount > numbers.Count)
                    {
                        if (operators.Peek() == '+')
                        {
                            operators.Pop();
                            numbers.Push(currentNum);
                            continue;
                        }
                        currentNum *= -1;
                        operators.Pop();
                    }
                    numbers.Push(currentNum);
                }
                else if (ch == 'x')
                {
                    // 4x + 30 - 10 + 2x = x + 10
                    var polarity = 1;
                    if (operators.Count > 0 && operators.Peek() == '-')
                    {
                        polarity = -1;
                    }
                    if (Char.IsDigit(expresion[i - 1]))
                    {
                        if (isEqualChar)
                        {
                            polarity = -1;
                        }
                        unknowns.Push(numbers.Pop() * polarity);
                    }
                    else
                    {
                        unknowns.Push(1 * polarity);
                    }
                    if (operators.Count > 0 )
                    {
                        operators.Pop();
                    }
                }
                else if (ch == '=')
                {
                    isEqualChar = true;
                }
            }
            while (operators.Count > 0)
            {
                var num2 = numbers.Pop();
                var num1 = numbers.Pop();
                var operat = operators.Pop();
                numbers.Push(Calculation(operat, num1, num2));
            }
            return numbers.Pop();
        }
        private static double Calculation(char ch, double num1, double num2)
        {
            switch (ch)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num1 / num2;
                case '^': return Math.Pow(num1, num2);
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
                case '^': return 3;
                default: return 0;
            }
        }
    }
}
