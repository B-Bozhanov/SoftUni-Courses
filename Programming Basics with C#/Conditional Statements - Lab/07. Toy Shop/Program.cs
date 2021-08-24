using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {  
            double excursionPrice = double.Parse(Console.ReadLine());

            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minons = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalSum = (puzzels * 2.60) + (dolls * 3.00) + (bears * 4.10) + (minons * 8.20) + (trucks * 2.00);

            if (puzzels + dolls + bears + minons + trucks >= 50)
            {
                totalSum *= 0.75;
            }
            totalSum *= 0.90;

            if (totalSum >= excursionPrice)
            {
                Console.WriteLine($"Yes! {totalSum - excursionPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - totalSum:f2} lv needed.");
            }

        }
    }
}
