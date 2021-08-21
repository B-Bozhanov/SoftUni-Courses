using System;

namespace T08PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double DOG_FOOD = 2.50;
            const double CAT_FOOD = 4.00;

            int dogPackages = int.Parse(Console.ReadLine());
            int catPackages = int.Parse(Console.ReadLine());

            double totalSum = (dogPackages * DOG_FOOD) + (catPackages * CAT_FOOD);

            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
