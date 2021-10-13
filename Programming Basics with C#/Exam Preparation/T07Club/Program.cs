using System;

namespace T07Club
{
    class Program
    {
        static void Main(string[] args)
        {

            double profit = double.Parse(Console.ReadLine());
            string cocktailName = Console.ReadLine();
            int numCocktail = int.Parse(Console.ReadLine());
            double cocktailPrice = 0;
            double totalPrice = 0;

            while (cocktailName != "Party!")
            {
                cocktailPrice = numCocktail * (cocktailName.Length);
                if (cocktailPrice % 2 != 0)
                {
                    cocktailPrice *= 0.75;
                }
                totalPrice += cocktailPrice;

                if (profit <= totalPrice)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {totalPrice:f2} leva.");
                    return;
                }

                cocktailName = Console.ReadLine();
                if (cocktailName == "Party!")
                {
                    Console.WriteLine($"We need {(profit - totalPrice):f2} leva more.");
                    Console.WriteLine($"Club income - {totalPrice:f2} leva.");
                    return;

                }
                numCocktail = int.Parse(Console.ReadLine());
            }

        }
    }
}
