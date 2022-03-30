using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keys = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckies = int.Parse(Console.ReadLine());

            double totalPrice = loveLetters * 0.60 + roses * 7.20 + keys * 3.60 + caricatures * 18.20 + luckies * 22.00;
            double count = loveLetters + roses + keys + caricatures + luckies;
            if (count >= 25)
            {
                totalPrice *= 0.65;
            }
            totalPrice *= 0.90;
            if (totalPrice  >= partyPrice)
            {
                Console.WriteLine($"Yes! {totalPrice  - partyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice  - totalPrice:f2} lv needed.");
            }
        }
    }
}
