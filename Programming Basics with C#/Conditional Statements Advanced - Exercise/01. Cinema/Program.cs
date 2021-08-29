using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Premiere – премиерна прожекция, на цена 12.00 лева.
            //⦁	Normal – стандартна прожекция, на цена 7.50 лева.
            //⦁	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00

            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());
            int rowAndColons = rows * colons;
            double totalPrice = 0;

            switch (projectionType)
            {
                case "Premiere":
                    totalPrice = rowAndColons * 12.00;
                    break;
                case "Normal":
                    totalPrice = rowAndColons * 7.50;
                    break;
                case "Discount":
                    totalPrice = rowAndColons * 5.00;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
