using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 10 20 30 30 40 1 50 2 3 4 5 6
            // 7 3 5 8 -1 0 6 7
            //3 14 5 12 15 7 8 9 11 10 1

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();  //!!!!!
            int firstNum = 0;

            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {

                }
            }
        }
    }
}
