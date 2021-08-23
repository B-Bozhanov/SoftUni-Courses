using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double totalPrice = (chickenMenu * 10.35) + (fishMenu * 12.40) + (veganMenu * 8.15);
            double dessert = totalPrice * 0.20;
            double totalSum = totalPrice + dessert + 2.50;
            Console.WriteLine(totalSum);
        }
    }
}
