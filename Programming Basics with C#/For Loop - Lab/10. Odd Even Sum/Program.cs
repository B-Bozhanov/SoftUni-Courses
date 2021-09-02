using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int evenPositionSum = 0;
            int oddPositinSum = 0;

            for (int i = 0; i < input ; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenPositionSum += n;
                }
                else 
                {
                    oddPositinSum += n;
                }
            }
            int diff = Math.Abs(evenPositionSum - oddPositinSum);
            if (evenPositionSum == oddPositinSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenPositionSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
