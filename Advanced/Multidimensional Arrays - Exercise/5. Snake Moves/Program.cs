using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] filedDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = filedDimensions[0];
            int cols = filedDimensions[1];
            // Create the field size.
            char[,] field = new char[rows, cols];

            string snake = Console.ReadLine();
            bool IsLeftToRight = true;               
            int counter = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                if (IsLeftToRight) // Direction is left to right
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        field[row, col] = snake[counter];
                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                    IsLeftToRight = false;  // Change direction
                }
                else
                {
                    for (int col = field.GetLength(1) - 1; col >= 0; col--)    // Direction is right to left
                    {
                        field[row, col] = snake[counter];
                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                    IsLeftToRight = true;
                }
            }

            // Print the filed
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
