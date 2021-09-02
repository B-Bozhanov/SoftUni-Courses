using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            int giftNumber = 0;
            double money = 0;
            double currentMoney = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == 2)
                    {
                        money += 10 - 1;
                    }
                    else
                    {
                        money += (currentMoney + 10) -1;
                        currentMoney += 10;
                    }
                }
                else
                {
                    giftNumber += 1;
                }
            }
            double toysPrice = priceToys * giftNumber;
            double totalMoney = money + toysPrice;

            if (totalMoney >= priceMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - priceMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceMachine - totalMoney:f2}");
            }
        }
    }
}
