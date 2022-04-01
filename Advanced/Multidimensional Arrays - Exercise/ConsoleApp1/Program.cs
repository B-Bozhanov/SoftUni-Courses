using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] widthAndLength = Console.ReadLine()                  // Read int width and length of rectangle
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = widthAndLength[0];                             // Get rows of the matrix from index [0] in width and length. 
            int cols = widthAndLength[1];                             // Get coloms , from the same array. 

            int[] dimensions = Console.ReadLine()                          // Enter Sub matrix dimensions/ rows and cols
            .Split()
            .Select(x => int.Parse(x))
            .ToArray();
            int dRows = dimensions[0];
            int dCols = dimensions[1];

            int[,] numbers = new int[rows, cols];                     // Create matrix with size rows and cols from the input.

            // Fill the matrix

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine()                   // Reade input numbers to fill the array.
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = inputNumbers[col];
                }
            }

            // Find max sum of 3x3 square

            int maxSum = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;
            for (int row = 0; row <= numbers.GetLength(0) - dRows; row++)
            {
                int currSum = 0;
                for (int col = 0; col <= numbers.GetLength(1) - dCols; col++)
                {
                    for (int i = row; i < row + dRows; i++)
                    {
                        for (int j = col; j < col + dCols; j++)
                        {
                            currSum += numbers[i, j];
                        }
                    }

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                    currSum = 0;
                }
            }

            // Print max sqare og Sum and elements

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxRow; row < maxRow + dRows; row++)
            {
                for (int col = maxCol; col < maxCol + dCols; col++)
                {
                    Console.Write($"{numbers[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
