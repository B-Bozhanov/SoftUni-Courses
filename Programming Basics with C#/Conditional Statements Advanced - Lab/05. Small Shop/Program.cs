using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            string drink = Console.ReadLine();
            string city = Console.ReadLine();
            double  numOfDrink = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia":
                    switch (drink)
                    {
                        case "coffee":
                            Console.WriteLine(numOfDrink * 0.50);break;
                        case "water":
                            Console.WriteLine(numOfDrink * 0.80); break;
                        case "beer":
                            Console.WriteLine(numOfDrink * 1.20); break;
                        case "sweets":
                            Console.WriteLine(numOfDrink * 1.45); break;
                        case "peanuts":
                            Console.WriteLine(numOfDrink * 1.60); break;
                    }
                    break;
                case "Plovdiv":
                    switch (drink)
                    {
                        case "coffee":
                            Console.WriteLine(numOfDrink * 0.40); break;
                        case "water":
                            Console.WriteLine(numOfDrink * 0.70); break;
                        case "beer":
                            Console.WriteLine(numOfDrink * 1.15); break;
                        case "sweets":
                            Console.WriteLine(numOfDrink * 1.30); break;
                        case "peanuts":
                            Console.WriteLine(numOfDrink * 1.50); break;
                    }
                    break;
                case "Varna":
                    switch (drink)
                    {
                        case "coffee":
                            Console.WriteLine(numOfDrink * 0.45); break;
                        case "water":
                            Console.WriteLine(numOfDrink * 0.70); break;
                        case "beer":
                            Console.WriteLine(numOfDrink * 1.10); break;
                        case "sweets":
                            Console.WriteLine(numOfDrink * 1.35); break;
                        case "peanuts":
                            Console.WriteLine(numOfDrink * 1.55); break;
                    }
                    break;


            }
        }
    }
}
