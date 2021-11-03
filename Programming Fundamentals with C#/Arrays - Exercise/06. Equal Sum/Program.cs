using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 5 5 99 3 4 2 5 1 1 4

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool IsEqual = false;
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                index = i;
               
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine($"{i}");
                    return;
                    //IsEqual = true;
                    //break;
                }
                //else
                //{
                //    IsEqual = false;
                //}
            }
                Console.WriteLine("no");
        }
    }
}
