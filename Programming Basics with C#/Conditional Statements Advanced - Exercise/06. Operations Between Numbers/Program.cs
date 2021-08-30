using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = int.Parse(Console.ReadLine());
            double N2 = int.Parse(Console.ReadLine());
            char symbol = Console.ReadLine()[0];
            char operat = ' ';
            double result = 0;
            switch (symbol)
            {
                case '+':
                    operat = '+';
                    result = N1 + N2; break;
                case '-':
                    operat = '-';
                    result = N1 - N2; break;
                case '*':
                    operat = '*';
                    result = N1 * N2; break;
                case '/':
                    operat = '/';
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                        return;
                    }
                    result = N1 / N2;
                    if (result % 2 ==0)
                    {
                        Console.WriteLine($"{N1} {operat} {N2} = {result}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operat} {N2} = {result:f2}");
                        return;
                    }
                case '%':
                    operat = '%';
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                        return;
                    }
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {operat} {N2} = {result} ");
                    return;
            }
            if (result % 2 == 0)
            {
                Console.WriteLine($"{N1} {operat} {N2} = {result} - even");
            }
            else 
            {
                Console.WriteLine($"{N1} {operat} {N2} = {result} - odd");
            }
            




        }
    }


}
