using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 14 24 3 19 15 17
            // 1 4 3 2
            // 27 19 42 2 13 45 48

            for (int i = 0; i < input.Length; i++)
            {
                int maxNum = 0; // bool IsBigger= false
                if (i == input.Length - 1)
                {
                    Console.Write($"{input[i]} ");
                    return;
                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        maxNum = input[i]; // IsBigger = true;
                    }
                    else
                    {
                        maxNum = 0;
                        break;
                    }
                }
                if (maxNum > 0)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}



