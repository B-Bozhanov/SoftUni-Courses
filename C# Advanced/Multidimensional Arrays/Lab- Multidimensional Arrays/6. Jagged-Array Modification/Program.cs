using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] input = new int[n, n];

            for (int row = 0; row < input.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();
                for (int col = 0; col < input.GetLength(1); col++)
                {
                    input[row, col] = numbers[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);


                if (action == "Add")
                {
                    input[row, col] += value;
                }
                else if (action == "Subtract")
                {
                    input[row, col] -= value;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
