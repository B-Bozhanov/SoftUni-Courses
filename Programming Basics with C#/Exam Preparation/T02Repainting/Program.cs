using System;

namespace T02Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double Price = ((nylon + 2) * 1.50) + ((paint * 1.1) * 14.50) + (thinner * 5) + 0.40;            
            double workPrice = (Price * 0.30) * hours;
            Console.WriteLine($"Total expenses: {(Price + workPrice):f2} lv.");
        }
    }
}
