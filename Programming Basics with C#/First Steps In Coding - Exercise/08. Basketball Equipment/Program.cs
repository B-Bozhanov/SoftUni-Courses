using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearFee = double.Parse(Console.ReadLine());

            double shoes = yearFee * 0.60;
            double clothes = shoes * 0.80;
            double ball = clothes / 4;
            double accesoaries = ball / 5;
            double totalSum = shoes + clothes + ball + accesoaries + yearFee;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
