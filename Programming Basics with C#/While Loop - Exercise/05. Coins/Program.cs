using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.75 => 175
            double coinChange = double.Parse(Console.ReadLine());
            double converted = coinChange * 100;
            int cents = (int)converted;
            // 220
            int counter = 0;
            while (cents != 0)
            {
                if (cents >= 200)
                {
                    cents -= 200;
                    counter++;
                }
                else if (cents >= 100)
                {
                    cents -= 100;
                    counter++;
                }
                else if (cents >= 50)
                {
                    cents -= 50;
                    counter++;
                }
                else if (cents >= 20)
                {
                    cents -= 20;
                    counter++;
                }
                else if (cents >= 10)
                {
                    cents -= 10;
                    counter++;
                }
                else if (cents >= 5)
                {
                    cents -= 5;
                    counter++;
                }
                else if (cents >= 2)
                {
                    cents -= 2;
                    counter++;
                }
                else if (cents >= 1)
                {
                    cents -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
