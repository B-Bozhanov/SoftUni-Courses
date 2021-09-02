using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < input*2; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (i < input)
                {
                    firstSum += n;
                }
                else if (i >= input)
                {
                    secondSum += n;
                }
            }
            int diff = Math.Abs(firstSum - secondSum);
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }

            //for (int i = 0; i < input; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    firstSum += n;
            //}
            //for (int i = 0; i < input; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    secondSum += n;
            //}
            //int diff = Math.Abs(firstSum - secondSum);
            //if (firstSum == secondSum)
            //{
            //    Console.WriteLine($"Yes, sum = {firstSum}");
            //}
            //else
            //{
            //    Console.WriteLine($"No, diff = {diff}");
            //}
        }
    }
}
