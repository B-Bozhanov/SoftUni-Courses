using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            char[,] pond = new char[size, size];
            var beaver = new Beaver();  // -1 by default: 

            int totalBraches = FillPondAndGetInfo(pond, beaver);


            Possition[] directions = new Possition[]
            {
                new Possition(-1, 0), // up
                new Possition(1, 0),  // down
                new Possition(0, -1), // left
                new Possition(0, 1),  // right
            };
            var direction = 0;

            var commands = Console.ReadLine();
            while (commands != "end")
            {
                int lengthOfPond = 0;

                if (totalBraches == 0) // If branches are zero, the beaver is collected all  branches in the pond:
                {
                    Console.WriteLine($"The Beaver successfully collect {beaver.Branches.Count} wood branches: {string.Join(", ", beaver.Branches.Reverse())}.");
                    PrintPond(pond);
                    return;
                }

                if (commands == "up")
                {
                    direction = 0;
                    lengthOfPond = pond.GetLength(0) - 1;
                }
                else if (commands == "down")
                {
                    direction = 1;
                }
                else if (commands == "left")
                {
                    direction = 2;
                }
                else if (commands == "right")
                {
                    direction = 3;
                    lengthOfPond = pond.GetLength(1) - 1;
                }

                Possition nextDirection = directions[direction];

                beaver.Move(pond, nextDirection, lengthOfPond);
                if (beaver.IsFindBranch)
                {
                    totalBraches--;
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {beaver.Branches.Count} branches left.");
            PrintPond(pond);
        }


        private static int FillPondAndGetInfo(char[,] pond, Beaver beaver)
        {
            int count = 0;
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                char[] fieldInfo = Console.ReadLine().Where(x => x != ' ').ToArray();

                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    if (fieldInfo[col] == beaver.Name)
                    {
                        beaver.Coords.Row = row;
                        beaver.Coords.Col = col;
                    }
                    if (Char.IsLower(fieldInfo[col]))
                    {
                        count++;
                    }
                    pond[row, col] = fieldInfo[col];
                }
            }
            return count;
        }
        private static void PrintPond(char[,] pond)
        {
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    Console.Write($"{pond[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Beaver
    {
        public Beaver()
        {
            this.Branches = new Stack<char>();
            this.Coords = new Possition();
            this.Name = 'B';
        }

        public Possition Coords { get; set; }
        public Stack<char> Branches { get; private set; }
        public char Name { get; private set; }
        public bool IsFindBranch { get; private set; }


        public void Move(char[,] pond, Possition direction, bool isUp, bool isLeft)
        {
            if (IsRange(pond, Coords.Row + direction.Row, Coords.Col + direction.Col))
            {
                pond[this.Coords.Row, this.Coords.Col] = '-';
                this.Coords.Row += direction.Row;
                this.Coords.Col += direction.Col;
                CollectBranches(pond);

                if (pond[this.Coords.Row, this.Coords.Col] == 'F')
                {
                    pond[this.Coords.Row, this.Coords.Col] = '-';
                    Swim();
                }

                pond[this.Coords.Row, this.Coords.Col] = this.Name;
            }
            else
            {
                if (this.Branches.Any())
                {
                    this.Branches.Pop();
                }
                IsFindBranch = false;
            }

            void Swim()
            {
                if (Coords.Row == 0)  // Move to the last down
                {
                    Coords.Row = pond.GetLength(0) - 1;
                    CollectBranches(pond);

                }
                else if (Coords.Row == pond.GetLength(0) - 1) // Move to zero index
                {
                    Coords.Row = 0;
                    CollectBranches(pond);
                }
                else if (Coords.Col == 0) // Move to last index right
                {
                    Coords.Col = pond.GetLength(1) - 1;
                    CollectBranches(pond);
                }
                else if (Coords.Col == pond.GetLength(1) - 1) // Move to zero index
                {
                    Coords.Col = 0;
                    CollectBranches(pond);
                }
                else
                {
                    switch (isUp)
                    {
                        case true:
                            Coords.Row = 0;
                            CollectBranches(pond); break;
                        case false:
                            Coords.Row = pond.GetLength(0) - 1;
                            CollectBranches(pond); break;
                    }
                    switch (isLeft)
                    {
                        case true:
                            Coords.Col = 0;
                            CollectBranches(pond); break;
                        case false:
                            Coords.Col = pond.GetLength(1) - 1;
                            CollectBranches(pond); break;
                    }
                }
            }
        }
        private void CollectBranches(char[,] pond)
        {
            if (Char.IsLower(pond[this.Coords.Row, this.Coords.Col]))
            {
                this.Branches.Push(pond[this.Coords.Row, this.Coords.Col]);
                IsFindBranch = true;
            }
            else
            {
                IsFindBranch = false;
            }
        }
        private bool IsRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }
    }

    public class Possition
    {
        public Possition(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        public Possition()
        {
            this.Row = 0;
            this.Col = 0;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}