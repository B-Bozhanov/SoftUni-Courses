using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ROSE = 5.00;
            const double DAHLIA = 3.80;
            const double TULIP = 2.80;
            const double NARCISSUS = 3.00;
            const double GLADIOLUS = 2.50;


            string flowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (flowers)
            {
                case "Roses":
                    totalPrice = numOfFlowers * ROSE;
                    if (numOfFlowers > 80)
                    {
                        totalPrice *= 0.90;
                    }
                    break;
                case "Dahlias":
                    totalPrice = numOfFlowers * DAHLIA;
                    if (numOfFlowers > 90)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Tulips":
                    totalPrice = numOfFlowers * TULIP;
                    if (numOfFlowers > 80)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Narcissus":
                    totalPrice = numOfFlowers * NARCISSUS;
                    if (numOfFlowers < 120)
                    {
                        totalPrice *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = numOfFlowers * GLADIOLUS;
                    if (numOfFlowers < 80)
                    {
                        totalPrice *= 1.20;
                    }
                    break;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
