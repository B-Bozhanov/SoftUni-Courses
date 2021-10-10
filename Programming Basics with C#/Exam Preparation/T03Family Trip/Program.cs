using System;

namespace T03Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightsPrice = double.Parse(Console.ReadLine());
            double percentOtherCost = double.Parse(Console.ReadLine());
            
            if (nights > 7)
            {
                nightsPrice *= 0.95;
            }
            double totalSum = ((nights * nightsPrice) + ((percentOtherCost / 100) * budget));
            if (totalSum <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget - totalSum):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(totalSum - budget):f2} leva needed.");
            }
        }
    }
}
