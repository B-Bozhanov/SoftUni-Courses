using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int max = int.MinValue;

            for (int i = 0; i < input; i++)
            {
                int num
                    = int.Parse(Console.ReadLine());
                totalSum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            int sumWithoutMax = totalSum - max;

            if (sumWithoutMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - sumWithoutMax)}");
            }
        }
    }
}
