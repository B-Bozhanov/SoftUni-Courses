using System;

namespace T04Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double videoCardPrice = cards * 250;

            double processorsPrice = processors * (videoCardPrice * 0.35);
            double ramPrice = ram * (videoCardPrice * 0.1);
            double totalPrice = totalPrice = videoCardPrice + processorsPrice + ramPrice;

            if (cards > processors)
            {
                totalPrice *=  0.85;
            }           
            if (totalPrice <= budjet)
            {
                Console.WriteLine($"You have {(budjet - totalPrice):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budjet):f2} leva more!");
            }
        }
    }
}