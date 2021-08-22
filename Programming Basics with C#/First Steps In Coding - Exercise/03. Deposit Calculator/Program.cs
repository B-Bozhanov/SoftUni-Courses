using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositEnd = int.Parse(Console.ReadLine());
            double percentPerYear = double.Parse(Console.ReadLine());

            double totalSum = (depositSum * (percentPerYear / 100) / 12) * depositEnd + depositSum;
            Console.WriteLine(totalSum);
        }
    }
}
