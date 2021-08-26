using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int extraMin = num2 + 15;

            if (extraMin >= 60)
            {
                extraMin -= 60;
                num1++;
            }
            if (num1 > 23 )
            {
                num1 = 0;
            }

            Console.WriteLine($"{num1}:{extraMin:d2}");

        }
    }
}
