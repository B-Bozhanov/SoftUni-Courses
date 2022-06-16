using System;

namespace TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            var armor = int.Parse(Console.ReadLine());
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new char[fieldSize][];
            var armyPossition = new int[2];

            for (int row = 0; row < field.Length; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                field[row] = input;
                for (int col = 0; col < input.Length; col++)
                {
                    if (field[row][col] == 'A')
                    {
                        armyPossition[0] = row;
                        armyPossition[1] = col;
                    }
                }
            }

            var armyRow = armyPossition[0];
            var armyCol = armyPossition[1];
            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var action = commands[0];
                var orcRow = int.Parse(commands[1]);
                var orcCol = int.Parse(commands[2]);

                if (IsRange(field, orcRow, orcCol))
                {
                    field[orcRow][orcCol] = 'O';
                }

                armor--;

                int row = 0;
                int col = 0;
                switch (action)
                {
                    case "up": row = -1; break;
                    case "down": row = 1; break;
                    case "left": col = -1; break;
                    case "right": col = 1; break;
                }

                if (IsRange(field, armyRow + row, armyCol + col))
                {
                    if (field[armyRow + row][armyCol + col] == 'O')
                    {
                        armor -= 2;
                        field[armyRow][armyCol] = '-';
                        armyRow += row;
                        armyCol += col;
                        IsDie(armor, field, armyRow, armyCol);
                        field[armyRow][armyCol] = 'A';
                    }
                    else if (field[armyRow + row][armyCol + col] == 'M')
                    {
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                        field[armyRow][armyCol] = '-';
                        field[armyRow + row][armyCol + col] = '-';
                        PrintMatrix(field);
                        return;
                    }
                    else
                    {
                        field[armyRow][armyCol] = '-';
                        armyRow += row;
                        armyCol += col;
                        IsDie(armor, field, armyRow, armyCol);
                        field[armyRow][armyCol] = 'A';
                    }
                }
            }
        }
        private static void IsDie(int armor, char[][] field, int armyRow, int armyCol)
        {
            if (armor <= 0)
            {
                field[armyRow][armyCol] = 'X';
                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                PrintMatrix(field);
                Environment.Exit(0);
            }
        }
        private static bool IsRange(char[][] field, int row, int col)
        {
            return row >= 0 && row < field.Length && col >= 0 && col < field[row].Length;
        }
        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}

