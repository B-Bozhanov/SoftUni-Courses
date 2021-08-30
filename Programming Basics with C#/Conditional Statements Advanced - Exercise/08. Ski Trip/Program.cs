using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfStay = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            double totalSum = 0;

            if (daysOfStay < 10)
            {
                switch (kindOfRoom)
                {
                    case "room for one person":
                        totalSum = (daysOfStay - 1) * 18.00;break;
                    case "apartment":
                        totalSum = ((daysOfStay - 1) * 25.00) * 0.70; break;
                    case "president apartment":
                        totalSum = ((daysOfStay - 1) * 35.00) * 0.90; break;
                }
            }
            else if (daysOfStay <= 15)
            {
                switch (kindOfRoom)
                {
                    case "room for one person":
                        totalSum = (daysOfStay - 1) * 18.00; break;
                    case "apartment":
                        totalSum = ((daysOfStay - 1) * 25.00) * 0.65; break;
                    case "president apartment":
                        totalSum = ((daysOfStay - 1) * 35.00) * 0.85; break;
                }
            }
            else if (daysOfStay > 15)
            {
                switch (kindOfRoom)
                {
                    case "room for one person":
                        totalSum = (daysOfStay - 1) * 18.00; break;
                    case "apartment":
                        totalSum = ((daysOfStay - 1) * 25.00) * 0.50; break;
                    case "president apartment":
                        totalSum = ((daysOfStay - 1) * 35.00) * 0.80; break;
                }
            }
            if (grade == "positive")
            {
                totalSum *= 1.25;
            }
            else
            {
                totalSum *= 0.90;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
