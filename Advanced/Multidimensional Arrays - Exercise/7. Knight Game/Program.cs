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
            char[,] board = new char[n, n];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string knights = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = knights[col];
                }
            }

            int deletedKnights = 0;

            while (true)
            {
                int maxAttacks = 0;
                int maxRow = -1;
                int maxCols = -1;

                for (int row = 0; row < board.GetLength(0); row++)
                {

                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentAttacks = 0;

                        if (board[row, col] != 'K')
                        {
                            continue;
                        }

                        if (IsInRange(board, row - 2, col + 1))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row - 1, col + 2))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row + 1, col + 2))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row + 2, col + 1))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row + 2, col - 1))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row + 1, col - 2))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row - 1, col - 2))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                        if (IsInRange(board, row - 2, col - 1))
                        {
                            currentAttacks++;
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCols = col;
                            }
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    break;
                }
                else
                {
                    board[maxRow, maxCols] = 'O';
                    deletedKnights++;
                }
            }

            Console.WriteLine(deletedKnights);
        }

        static bool IsInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0)
                   && col >= 0 && col < board.GetLength(1)
                   && board[row, col] == 'K';
        }
    }
}
