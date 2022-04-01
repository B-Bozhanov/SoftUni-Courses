using System;
using System.Collections.Generic;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(); // !!!!
            string[,] field = new string[n, n];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = elements[col];
                }
            }

            int minnerRow = -1;
            int minnerCol = -1;
            string gameOver = "e";
            string coals = "c";
            string minner = "s";
            int points = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == minner)
                    {
                        minnerRow = row;
                        minnerCol = col;
                    }
                    if (field[row, col] == coals)
                    {
                        points++;
                    }
                }
            }


            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    if (minnerRow - 1 < 0)
                    {
                        continue;
                    }
                    if (field[minnerRow - 1, minnerCol] == gameOver)
                    {
                        minnerRow++;
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol})");
                        return;
                    }
                    if (field[minnerRow - 1, minnerCol] == coals)
                    {
                        points--;
                    }
                    field[minnerRow - 1, minnerCol] = field[minnerRow, minnerCol];
                    field[minnerRow, minnerCol] = "*";
                    minnerRow--;
                }
                else if (commands[i] == "down")
                {
                    if (minnerRow + 1 >= field.GetLength(0))
                    {
                        continue;
                    }
                    if (field[minnerRow + 1, minnerCol] == gameOver)
                    {
                        minnerRow++;
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol})");
                        return;
                    }
                    if (field[minnerRow + 1, minnerCol] == coals)
                    {
                        points--;
                    }
                    field[minnerRow + 1, minnerCol] = field[minnerRow, minnerCol];
                    field[minnerRow, minnerCol] = "*";
                    minnerRow++;
                }
                else if (commands[i] == "left")
                {
                    if (minnerCol - 1 < 0)
                    {
                        continue;
                    }
                    if (field[minnerRow, minnerCol - 1] == gameOver)
                    {
                        minnerCol++;
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol})");
                        return;
                    }
                    if (field[minnerRow, minnerCol - 1] == coals)
                    {
                        points--;
                    }
                    field[minnerRow, minnerCol - 1] = field[minnerRow, minnerCol];
                    field[minnerRow, minnerCol] = "*";
                    minnerCol--;
                }
                else if (commands[i] == "right")
                {
                    if (minnerCol + 1 >= field.GetLength(1))
                    {
                        continue;
                    }
                    if (field[minnerRow, minnerCol + 1] == gameOver)
                    {
                        minnerCol++;
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol})");
                        return;
                    }
                    if (field[minnerRow, minnerCol + 1] == coals)
                    {
                        points--;
                    }
                    field[minnerRow, minnerCol + 1] = field[minnerRow, minnerCol];
                    field[minnerRow, minnerCol] = "*";
                    minnerCol++;
                }
            }

            if (points == 0)
            {
                Console.Write($"You collected all coals! ({ minnerRow}, { minnerCol})");
            }
            else
            {
                Console.WriteLine($"{points} coals left. ({minnerRow}, {minnerCol})");
            }

           
        }
    }
}
