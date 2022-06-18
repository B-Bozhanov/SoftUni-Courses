using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    internal class Program
    {
        
        private static int beaverRow = -1;
        private static int beaverCol = -1;
        private static int swiming;
        private static bool isLeftOrRight;

        private static Stack<char> woods = new Stack<char>();
        private static int woodBranches = 0;

        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var field = new char[size, size];
            var beaver = new Beaver(-1, -1);  // -1 by default: 
            FillMatrix(field, beaver);
            

            while (true)
            {
                var commands = Console.ReadLine();
                var move = 0;

                if (woodBranches == 0)
                {
                    break;
                }
                else if (commands == "end")
                {
                    break;
                }
                else if (commands == "up")
                {
                    move = -1;
                }
                else if (commands == "up")
                {
                    move = -1;
                }
                else if (commands == "up")
                {
                    move = -1;
                }
                else if (commands == "up")
                {
                    move = -1;
                }

                var direction = GetDirection(commands);
                var row = direction[0];
                var col = direction[1];
                BeaverMove(beaverRow + row, beaverCol + col, swiming, isLeftOrRight);
            }

            if (woodBranches > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranches} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {woods.Count} wood branches: {string.Join(", ", woods.Reverse())}.");
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(char[,] field, Beaver beaver)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] fieldInfo = Console.ReadLine().Where(x => x != ' ').ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (fieldInfo[col] == 'B')
                    {
                        beaver.Possition.Row = row;
                        beaver.Possition.Col = col;
                    }
                    else if (Char.IsLower(fieldInfo[col]))
                    {
                        beaver.Branches.Push(fieldInfo[col]);
                    }
                    field[row, col] = fieldInfo[col];
                }
            }
        }

        private static bool IsRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }
        private static void BeaverMove(int row, int col, int direction, bool isLeftOrRight)
        {
            if (!IsRange(field, row, col))
            {
                if (woods.Count > 0)
                {
                    woods.Pop();
                }
                return;
            }

            if (field[row, col] == 'F')
            {
                if (isLeftOrRight)
                {
                    if (Char.IsLower(field[row, direction]))
                    {
                        woods.Push(field[row, direction]);
                        woodBranches--;
                    }
                    field[row, direction] = 'B';
                    field[row, col] = '-';
                    field[beaverRow, beaverCol] = '-';
                    beaverRow = row;
                    beaverCol = direction;
                    return;
                }
                if (Char.IsLower(field[direction, col]))
                {
                    woods.Push(field[direction, col]);
                    woodBranches--;
                }
                field[direction, col] = 'B';
                field[row, col] = '-';
                field[beaverRow, beaverCol] = '-';
                beaverRow = direction;
                beaverCol = col;
            }
            else
            {
                if (Char.IsLower(field[row, col]))
                {
                    woods.Push(field[row, col]);
                    woodBranches--;
                }
                field[row, col] = 'B';
                field[beaverRow, beaverCol] = '-';
                beaverRow = row;
                beaverCol = col;
            }
        }

        private static int[] GetDirection(string commands)
        {
            var direction = new int[2];
            if (commands == "up")
            {
                direction[0] = -1;
                direction[1] = 0;
                if (!IsRange(field, beaverRow - 2, beaverCol)
                    && IsRange(field, beaverRow - 1, beaverCol)
                    && field[beaverRow - 1, beaverCol] == 'F')
                {
                    swiming = field.GetLength(0) - 1;
                }
                else
                {
                    swiming = 0;
                }
                isLeftOrRight = false;
            }
            else if (commands == "down")
            {
                if (!IsRange(field, beaverRow + 2, beaverCol)
                   && IsRange(field, beaverRow + 1, beaverCol)
                   && field[beaverRow + 1, beaverCol] == 'F')
                {
                    swiming = 0;
                }
                else
                {
                    swiming = swiming = field.GetLength(0) - 1;
                }
                direction[0] = +1;
                direction[1] = 0;
                isLeftOrRight = false;
            }
            else if (commands == "left")
            {
                direction[0] = 0;
                direction[1] = -1;
                if (!IsRange(field, beaverRow, beaverCol - 2)
                   && IsRange(field, beaverRow, beaverCol - 1)
                   && field[beaverRow, beaverCol - 1] == 'F')
                {
                    swiming = field.GetLength(1) - 1;
                }
                else
                {
                    swiming = 0;
                }
                isLeftOrRight = true;
            }
            else if (commands == "right")
            {
                direction[0] = 0;
                direction[1] = 1;
                if (!IsRange(field, beaverRow, beaverCol + 2)
                   && IsRange(field, beaverRow, beaverCol + 1)
                   && field[beaverRow, beaverCol + 1] == 'F')
                {
                    swiming = 0;
                }
                else
                {
                    swiming = swiming = field.GetLength(1) - 1;
                }
                isLeftOrRight = true;
            }

            return direction;
        }
    }
    internal class Beaver
    {
        public Beaver(int row, int col)
        {
            this.Branches = new Stack<char>();
            this.Possition = new Possition(row, col);
            this.Name = 'B';
        }

        public Possition Possition { get; set; }
        public Stack<char> Branches { get; private set; }
        public char Name { get; private set; }


        public Possition Move(char[,] pond, int row, int col)
        {
            this.Possition.Row += row;
            this.Possition.Col += col;
            return this.Possition;
        }
        public void Swim(char[,] pond)
        {

        }
        public void Collect(char branch)
        {
            this.Branches.Push(branch);
        }
        public void DisCollect()
        {
            if (this.Branches.Any())
            {
                this.Branches.Pop();
            }
        }
    }

    public class Possition
    {
        public Possition(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}