using System;
using System.Collections.Generic;
using System.Linq;

namespace Bricks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] chars = new string[rows, cols];
            int count = 0;

            for (int row = 0; row < chars.GetLength(0); row++)
            {
                string[] matrixChars = Console.ReadLine().Split();

                for (int col = 0; col < chars.GetLength(1); col++)
                {
                    chars[row, col] = matrixChars[col];
                }
            }

            for (int row = 0; row < chars.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < chars.GetLength(1) - 1; col++)
                {
                    if (chars[row, col] == chars[row, col + 1]
                       && chars[row, col] == chars[row + 1, col]
                       && chars[row, col] == chars[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
