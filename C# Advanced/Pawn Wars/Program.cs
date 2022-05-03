using System;

namespace Pawn_Wars
{
    struct Coordinates
    {
        public int Row;
        public int Col;
        public Coordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var whitePawn = new Coordinates(0, 0);
            var blackPawn = new Coordinates(0, 0);

            var board = new char[8, 8];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (input[col] == 'w')
                    {
                        whitePawn.Row = row;
                        whitePawn.Col = col;
                    }
                    if (input[col] == 'b')
                    {
                        blackPawn.Row = row;
                        blackPawn.Col = col;
                    }
                    board[row, col] = input[col];
                }
            }

            while (true)
            {
                if (IsRange(board, whitePawn.Row - 1, whitePawn.Col - 1))
                {
                    if (board[whitePawn.Row - 1, whitePawn.Col - 1] == 'b')
                    {
                        // TODO: White wining.
                        whitePawn.Row -= 1;
                        whitePawn.Col -= 1;
                        var coordinates = ReturnCoordinates(whitePawn);
                        Console.WriteLine($"Game over! white capture on {(char)coordinates.Col}{coordinates.Row}.");

                    }
                    else if (board[whitePawn.Row - 1, whitePawn.Col + 1] == 'b')
                    {
                        // TODO: White wining.
                    }
                    else
                    {
                        board[whitePawn.Row, whitePawn.Col] = '-';
                        board[whitePawn.Row - 1, whitePawn.Col] = 'w';
                        whitePawn.Row -= 1;
                    }

                    if (whitePawn.Row - 1 == 0)
                    {
                        // TODO: White wining.
                        break;
                    }
                    
                }
            }
        }
        private static bool IsRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0)
                && col >= 0 && col < board.GetLength(1);
        }
        private static Coordinates ReturnCoordinates(Coordinates whitePawn)
        {
            var coordinates = new Coordinates(whitePawn.Row, whitePawn.Col);
            switch (whitePawn.Row)
            {
                case 0: coordinates.Row = 8 ; break;
                case 1: coordinates.Row = 7 ; break;
                case 2: coordinates.Row = 6 ; break;
                case 3: coordinates.Row = 5 ; break;
                case 4: coordinates.Row = 4 ; break;
                case 5: coordinates.Row = 3 ; break;
                case 6: coordinates.Row = 2 ; break;
                case 7: coordinates.Row = 1 ; break;
            }
            switch (whitePawn.Col)
            {
                case 0: coordinates.Col = 'a'; break;
                case 1: coordinates.Col = 'b'; break;
                case 2: coordinates.Col = 'c'; break;
                case 3: coordinates.Col = 'd'; break;
                case 4: coordinates.Col = 'e'; break;
                case 5: coordinates.Col = 'f'; break;
                case 6: coordinates.Col = 'g'; break;
                case 7: coordinates.Col = 'h'; break;
            }
            return coordinates;
        }
    }
}
