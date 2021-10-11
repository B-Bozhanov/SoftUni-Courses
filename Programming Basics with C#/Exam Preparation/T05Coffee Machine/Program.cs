using System;

namespace T05Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numOfDrink = int.Parse(Console.ReadLine());

            double drinkPrice = 0;
            
            switch (drink)
            {
                case "Espresso":
                    switch (sugar)
                    {
                        case "Without":
                            drinkPrice = 0.90 * 0.65 ; break;
                        case "Normal":
                            drinkPrice = 1.00; break;
                        case "Extra":
                            drinkPrice = 1.20; break;
                    }
                    if (numOfDrink >= 5)
                    {
                        drinkPrice *= 0.75;
                    }
                    break;

                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            drinkPrice = 1.00 * 0.65; break;
                        case "Normal":
                            drinkPrice = 1.20; break;
                        case "Extra":
                            drinkPrice = 1.60; break;
                    }
                    break;

                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            drinkPrice = 0.50 * 0.65; break;
                        case "Normal":
                            drinkPrice = 0.60; break;
                        case "Extra":
                            drinkPrice = 0.70; break;
                    }
                    break;
            }
            double totalPrice = numOfDrink * drinkPrice;
            if (totalPrice > 15)
            {
                totalPrice *= 0.80;
            }
            Console.WriteLine($"You bought {numOfDrink} cups of {drink} for {totalPrice:f2} lv.");
        }
    }
}
