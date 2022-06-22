using System;

namespace Bee
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new char[fieldSize, fieldSize];
            FillMatrix(field);
            int[] beeCords = GetBeeCordinates(field);
            var beeRow = beeCords[0];
            var beeCol = beeCords[1];
            var pollinatedFlowers = 0;

            var command = Console.ReadLine();
            while (command != "End")
            {
                var directRow = 0;
                var directCol = 0;

                switch (command)
                {
                    case "up": directRow -= 1; break;
                    case "down": directRow += 1; break;
                    case "left": directCol -= 1; break;
                    case "right": directCol += 1; break;
                }

                field[beeRow, beeCol] = '.';
                beeRow += directRow;
                beeCol += directCol;

                if (!IsRange(field, beeRow, beeCol))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                else if (field[beeRow, beeCol] == 'O')
                {
                    field[beeRow, beeCol] = '.';
                    continue;
                }
                if (field[beeRow, beeCol] == 'f')
                {
                    pollinatedFlowers++;
                }

                field[beeRow, beeCol] = 'B';

                command = Console.ReadLine();
            }

            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            PrintMatrix(field);
        }

        private static void PrintMatrix(char[,] field)
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
        private static int[] GetBeeCordinates(char[,] field)
        {
            var beeDirection = new int[2];
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        beeDirection[0] = row;
                        beeDirection[1] = col;
                    }
                }
            }
            return beeDirection;
        }

        private static void FillMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];
                }
            }
        }

        private static bool IsRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }
    }
}
