using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input
            int[] dimensions = Console.ReadLine()
               .Split()
               .Select(x => int.Parse(x))
               .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] input = new string[rows, cols];

            for (int row = 0; row < input.GetLength(0); row++)
            {
                string[] inputString = Console.ReadLine().Split();

                for (int col = 0; col < input.GetLength(1); col++)
                {
                    input[row, col] = inputString[col];
                }
            }

            // Logic to solve the problem
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command.Split();
                // Check the input is true.
                if (commandArgs.Length != 5 || commandArgs[0] != "swap")         
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                // Save swap command in value
                string action = commandArgs[0];
                // Parse rows and cols from the input parameters
                int row1 = int.Parse(commandArgs[1]);                           
                int col1 = int.Parse(commandArgs[2]);
                int row2 = int.Parse(commandArgs[3]);
                int col2 = int.Parse(commandArgs[4]);
                // Get length of rows and cols  on matrix.
                int inputRowsLength = input.GetLength(0);                       
                int inputColsLength = input.GetLength(1);
                // Check wether input cordinates are true.
                if (row1 <= inputRowsLength && row1 >= 0                       
                     && row2 <= inputRowsLength && row2 >= 0
                     && col1 <= inputColsLength && col1 >= 0
                     && col2 <= inputColsLength && col2 >= 0
                   )
                {
                    // Swap elements
                    string currentSymbol = input[row1, col1];                 
                    input[row1, col1] = input[row2, col2];
                    input[row2, col2] = currentSymbol;
                    //Print matrix
                    for (int row = 0; row < input.GetLength(0); row++)
                    {
                        for (int col = 0; col < input.GetLength(1); col++)
                        {
                            Console.Write($"{input[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
