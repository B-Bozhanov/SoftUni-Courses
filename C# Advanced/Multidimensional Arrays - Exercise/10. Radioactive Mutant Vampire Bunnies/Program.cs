using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] field = new char[rows, cols];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string commands = Console.ReadLine();
            bool IsWin = false;
            bool IsDead = false;

            foreach (var command in commands)
            {
                int nextRow = 0;
                int nextCol = 0;

                if (command == 'U')
                {
                    nextRow = -1;
                }
                else if (command == 'D')
                {
                    nextRow = 1;
                }
                else if (command == 'L')
                {
                    nextCol = -1;
                }
                else if (command == 'R')
                {
                    nextCol = 1;
                }

                field[playerRow, playerCol] = '.';

                if (!IsInRange(field, playerRow + nextRow, playerCol + nextCol))
                {
                    IsWin = true;
                }
                else
                {
                    playerRow += nextRow;
                    playerCol += nextCol;

                    if (field[playerRow, playerCol] == 'B')
                    {
                        IsDead = true;
                    }
                    else
                    {
                        field[playerRow, playerCol] = 'P';
                    }

                }

                List<int[]> bunnies = new List<int[]>();
                for (int row = 0; row < field.GetLength(0); row++)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        if (field[row, col] == 'B')
                        {
                            bunnies.Add(new int[] { row, col });
                        }
                    }
                }

                foreach (var bunny in bunnies)
                {
                    int bunnyRow = bunny[0];
                    int bunnyCol = bunny[1];

                    for (int row = -1; row <= 1; row += 2) // Direction left and right
                    {
                        if (IsInRange(field, bunnyRow + row, bunnyCol))
                        {
                            if (field[bunnyRow + row, bunnyCol] == 'P')
                            {
                                IsDead = true;
                            }
                            field[bunnyRow + row, bunnyCol] = 'B';
                        }
                    }
                    for (int col = -1; col <= 1; col += 2)   // Direction up and down
                    {
                        if (IsInRange(field, bunnyRow, bunnyCol + col))
                        {
                            if (field[bunnyRow, bunnyCol + col] == 'P')
                            {
                                IsDead = true;
                            }
                            field[bunnyRow, bunnyCol + col] = 'B';
                        }
                    }
                }
                if (IsWin)
                {
                    Print(field);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
                if (IsDead)
                {
                    Print(field);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
            }
        }
        static void Print(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
        static bool IsInRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }
    }
}
