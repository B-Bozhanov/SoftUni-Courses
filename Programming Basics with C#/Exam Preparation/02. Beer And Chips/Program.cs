using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string fan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());
            double priceOfBeer = beers * 1.20;
            double priceOfChips = Math.Ceiling(chips * (priceOfBeer * 0.45));
            double totalSum = priceOfBeer + priceOfChips;

            if (budget >= totalSum )
            {
                Console.WriteLine($"{fan} bought a snack and has {budget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{fan} needs {totalSum - budget:f2} more leva!");
            }
        }
    }
}
