using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportCard = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double totalPrice = peoples * (nights * 20.00 + transportCard *1.60 + tickets * 6.00);
            totalPrice *= 1.25;
            Console.WriteLine($"{totalPrice:f2}");
            Console.WriteLine(totalPrice + tickets);
        }
    }
}
