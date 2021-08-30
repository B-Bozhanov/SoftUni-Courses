using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.00;
                    apartmentPrice = 65.00;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        studioPrice *= 0.70;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioPrice *= 0.80;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;
                    break;
            }
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }

            double totalStudioPrice = studioPrice * nights;
            double totalApartmentPrice = apartmentPrice * nights;

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
