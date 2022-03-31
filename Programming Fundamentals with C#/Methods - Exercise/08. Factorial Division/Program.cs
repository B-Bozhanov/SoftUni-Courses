using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int secondOne = int.Parse(Console.ReadLine());
            double firstFactorial = 0;
            double secondFactorial = 0;
            firstFactorial = GetFactorial(numOne);
            secondFactorial = GetFactorial(secondOne);
            double result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");  
        }

        static double GetFactorial(double num)
        {
            double result = 1;
            for (double i = num; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
