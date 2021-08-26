using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Декорът за филма е на стойност 10 % от бюджета.
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.


            double budget = double.Parse(Console.ReadLine());
            int peoples = int.Parse(Console.ReadLine());
            double clothesPerManPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double clothesPrice = clothesPerManPrice * peoples;

            if (peoples > 150)
            {
                clothesPrice *= 0.90;
            }
            double totalPrice = decorPrice + clothesPrice;

            if (totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:f2} leva left.");
            }

        }
    }
}
