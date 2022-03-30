using System;

namespace _03._Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0;
          
            switch (kindOfRoom)
            {
                case "room for one person":
                    price = 18; break;
                case "apartment":
                    price = 25; break;
                case "president apartment":
                    price = 35; break;
            }
            double totalPrice = price * (days -1);
            if (days < 10)
            {
                switch (kindOfRoom)
                {
                    case "apartment":
                        totalPrice *= 0.70; break;
                    case "president apartment":
                        totalPrice *= 0.90; break;
                }
            }
            else if (days <= 15)
            {
                switch (kindOfRoom)
                {
                   case "apartment":
                        totalPrice *= 0.65; break;
                    case "president apartment":
                        totalPrice *= 0.85; break;
                }
            }
            else if (days > 15)
            {
                switch (kindOfRoom)
                {
                    case "apartment":
                        totalPrice *= 0.50; break;
                    case "president apartment":
                        totalPrice *= 0.80; break;
                }
            }
            if (grade == "positive")
            {
                totalPrice *= 1.25;
            }
            else if (grade == "negative")
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
