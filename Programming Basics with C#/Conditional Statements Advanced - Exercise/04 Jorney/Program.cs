using System;

namespace Submit_a_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalPrice = 0;
            string destination = " ";
            string nights = " ";



            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        totalPrice = budget * 0.30;
                        nights = "Camp";
                        break;
                    case "winter":
                        totalPrice = budget * 0.70; 
                        nights = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        totalPrice = budget * 0.40;
                        nights = "Camp";
                        break;
                    case "winter":
                        totalPrice = budget * 0.80; 
                        nights = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                switch (season)
                {
                    case "summer":
                    case "winter":
                        totalPrice = budget * 0.90;
                        nights = "Hotel";
                        break;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{nights} – {totalPrice:f2}");

        }
    }
}
