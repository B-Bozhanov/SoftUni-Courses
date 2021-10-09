using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double toyPrice = 5.00;
            double sweatersPrice = 15.00;
            int adults = 0;
            int kids = 0;

            while (command != "Christmas")
            {
                double ages = double.Parse(command);
                if (ages <= 16)
                {
                    kids++;
                }
                else
                {
                    adults++;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {kids * toyPrice}");
            Console.WriteLine($"Money for sweaters: {adults * sweatersPrice}");
        }
    }
}
