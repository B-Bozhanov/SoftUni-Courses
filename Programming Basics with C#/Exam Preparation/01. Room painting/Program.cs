using System;

namespace _01._Room_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            int paint = int.Parse(Console.ReadLine());
            int tapets = int.Parse(Console.ReadLine());
            double gloves = double.Parse(Console.ReadLine());
            double brush = double.Parse(Console.ReadLine());

            double totalPriceOfProducts = (paint * 21.50) + (tapets * 5.20) + (gloves * (Math.Ceiling(tapets * 0.35))) + (brush * (Math.Floor(paint * 0.48)));
            double delivery = totalPriceOfProducts / 15;
            Console.WriteLine($"This delivery will cost {delivery:f2} lv.");
            
        }
    }
}
