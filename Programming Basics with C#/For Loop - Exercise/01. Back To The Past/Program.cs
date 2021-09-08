using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearsToLive = int.Parse(Console.ReadLine());
            int age = 18;

            for (int i = 1800; i <= yearsToLive; i++)
            {
                if (i % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }
                else
                {
                    inheritedMoney -= 12000 + 50 * age;
                }
                age++;
            }
            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}
