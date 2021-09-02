using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int currentMax = int.MinValue;
            int currentMin = int.MaxValue;

            for (int i = 0; i < input; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n > currentMax)
                {
                    currentMax = n;
                }
                if (n < currentMin)
                {
                    currentMin = n;
                }

            }
            Console.WriteLine($"Max number: { currentMax}");
            Console.WriteLine($"Min number: { currentMin}");
        }
    }
}
