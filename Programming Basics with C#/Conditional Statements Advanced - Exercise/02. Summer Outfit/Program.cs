using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreece = int.Parse(Console.ReadLine());
            string weather = Console.ReadLine();
            string outfit = " ";
            string shoes = " ";


            if (degreece >= 10 && degreece <= 18)
            {
                switch (weather)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (degreece > 18 && degreece <= 24)
            {
                switch (weather)
                {
                    case "Morning":
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                }
            }
            else if (degreece >= 25)
            {
                switch (weather)
                {

                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            Console.WriteLine($"It's {degreece} degrees, get your {outfit} and {shoes}.");
        }
    }
}
