using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            // Брой пакети химикали - цяло число в интервала[0...100]
            // Брой пакети маркери - цяло число в интервала[0...100]
            // Литри препарат за почистване на дъска -цяло число в интервала[0…50]
            // Процент намаление -цяло число в интервала[0...100]
            //

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int littresPreparation = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalPrice = (pens * 5.80) + (markers * 7.20) + (littresPreparation * 1.20);
            double  totalDiscount =totalPrice * discount / 100;
            double totalSum = totalPrice - totalDiscount;
            Console.WriteLine(totalSum);
        }
    }
}
