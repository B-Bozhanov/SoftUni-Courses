using System;
using System.Collections.Generic;
using System.Linq;

namespace Bricks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];
            int diagonal1 = 0;
            int diagonal2 = 0;

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] inputNums = Console.ReadLine().Split()
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = inputNums[col];
                }
            }

            for (int row = 0; row < numbers.GetLength(0); row++)
            {

                diagonal1 += numbers[row, row];
                diagonal2 += numbers[row, (numbers.GetLength(1) - 1) - row];
            }

            int diference = Math.Abs(diagonal1 - diagonal2);
            Console.WriteLine(diference);
        }
    }
}
