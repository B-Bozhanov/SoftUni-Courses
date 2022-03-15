using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3, 6
            7, 1, 3, 3, 2, 1
            1, 3, 9, 8, 5, 6
            4, 6, 7, 9, 1, 0
            */

            int[] input = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] numbers = new int[rows, cols];

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = inputNumbers[col];
                }
            }
            int max = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;
            for (int i = 0; i < numbers.GetLength(0) - 1; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    currentSum = numbers[i, j] + numbers[i, j + 1] + numbers[i + 1, j] + numbers[i + 1, j + 1];

                    if (currentSum > max)
                    {
                        max = currentSum;
                        maxCol = j;
                        maxRow = i;
                    }
                }
            }
            // Print result
            for (int i = maxRow; i < maxRow + 2; i++)
            {
                for (int j = maxCol; j < maxCol + 2; j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(max);
        }
    }
}
