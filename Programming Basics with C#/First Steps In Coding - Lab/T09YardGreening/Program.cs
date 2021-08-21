using System;

namespace T09YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {

            double squareMeters = double.Parse(Console.ReadLine());
            double totalSum = (squareMeters * 7.61) * 0.82;
            double discount = (squareMeters * 7.61) * 0.18;

            Console.WriteLine($"The final price is: {totalSum:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");      	
        }
    }
}
