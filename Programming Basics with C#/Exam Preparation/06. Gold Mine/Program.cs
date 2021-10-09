using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= locations; i++)
            {
                double averageGold = 0;
                double totalGold = 0;
                double averageGoldPerDay = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int j = 1; j <= days; j++)
                {
                    double gold = double.Parse(Console.ReadLine());
                    totalGold += gold;
                }
                averageGold = totalGold / days;
                if (averageGold >= averageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {averageGoldPerDay - averageGold:f2} gold.");
                }
            }

        }
    }
}
