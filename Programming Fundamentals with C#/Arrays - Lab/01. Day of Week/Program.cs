using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string[] daysOFWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (days < 1 || days > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine($"{daysOFWeek[days - 1]}");
            }
        }
    }
}
