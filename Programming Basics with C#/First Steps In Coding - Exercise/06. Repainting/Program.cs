using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]
            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]
            //3.Количество разредител(в литри) - цяло число в интервала[1…30]
            //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]

            int quantityNaylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityPreparation = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double totalPrice = ((quantityNaylon + 2)* 1.50) + ((quantityPaint * 14.50) * 1.10) + (quantityPreparation * 5.00) + 0.40;
            double pricePerHour = totalPrice * 0.30;

            double totalSum = totalPrice + pricePerHour * workingHours;
            Console.WriteLine(totalSum);
        }
    }
}
