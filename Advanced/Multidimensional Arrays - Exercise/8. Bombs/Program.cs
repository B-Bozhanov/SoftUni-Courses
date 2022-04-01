using System;
using System.Collections.Generic;
using System.Linq;

namespace Bricks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Save input numbers in matrix.
            int n = int.Parse(Console.ReadLine());
            int[,] field = new int[n, n];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = numbers[col];
                }
            }
            // Save the cordinates in new matrix.
            string[] input = Console.ReadLine().Split();
            int[,] cordinates = new int[input.Length, 2];

            for (int row = 0; row < cordinates.GetLength(0); row++)
            {
                int[] inputArgs = input[row].Split(",").Select(int.Parse).ToArray();
                for (int col = 0; col < cordinates.GetLength(1); col++)
                {
                    cordinates[row, col] = inputArgs[col];
                }
            }

            for (int i = 0; i < cordinates.GetLength(0); i++)
            {
                int row = cordinates[i, 0];
                int col = cordinates[i, 1];
                int currBomb = field[row, col];

                for (int x = -1; x < 2; x++)
                {
                    for (int y = -1; y < 2; y++)
                    {
                        if (IsINRange(field, row + x, col + y) && currBomb > 0
                                     && field[row + x, col + y] > 0)
                        {
                            field[row + x, col + y] -= currBomb;
                        }
                    }
                }
            }


            int aliveNums = 0;
            int sum = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] > 0)
                    {
                        aliveNums++;
                        sum += field[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveNums}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write($"{field[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsINRange(int[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
        }
    }
}
