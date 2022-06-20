using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    public class Program
    {
        public static void Main()
        {
            char[,] pond = new char[5, 5];
            FillPond(pond);
            int[] pondInfo = GetPondInfo(pond);

            int totalBranches = pondInfo[2];
            Beaver beaver = new Beaver(pondInfo[0], pondInfo[1], 'B');

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                if (totalBranches == 0)
                {
                    break;
                }


                int row = 0;
                int col = 0;
                switch (command)
                {
                    case "up": row -= 1; break;
                    case "down": row += 1; break;
                    case "left": col -= 1; break;
                    case "right": col += 1; break;
                }

                beaver.Move(pond, row, col);
            }

        }
        private static void FillPond(char[,] pond)
        {
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    pond[row, col] = input[col];
                }
            }
        }
        private static int[] GetPondInfo(char[,] pond)
        {
            int[] info = new int[3];
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    if (pond[row, col] == 'B')
                    {
                        info[0] = row;
                        info[1] = col;
                    }
                    else if (Char.IsLower(pond[row, col]))
                    {
                        info[2] += 1;
                    }
                }
            }
            return info;
        }
    }
    public class Beaver
    {
        public Beaver(int row, int col, char name)
        {
            this.Row = row;
            this.Col = col;
            this.Name = name;
        }
        public int Row { get; set; }
        public int Col { get; set; }
        public char Name { get; set; }
        public Stack<char> Branches { get; private set; }


        public void Move(char[,] pond, int row, int col)
        {
            pond[this.Row, this.Col] = '-';
            this.Row += row;
            this.Col += col;

            if (!IsRange(pond, this.Row, this.Col))
            {
                this.Row -= row;
                this.Col -= col;
                pond[this.Row, this.Col] = this.Name;
                this.Branches.Pop();
            }
            else if (pond[this.Row, this.Col] == 'F')
            {
                pond[this.Row, this.Col] = this.Name;
                if (this.Row == 0)
                {
                    this.Row = pond.GetLength(0) - 1;
                }
                else if (this.Row == pond.GetLength(0) - 1)
                {
                    this.Row = 0;
                }
                else if (this.Col == 0)
                {
                    this.Col = pond.GetLength(1) - 1;
                }
                else if (this.Col == pond.GetLength(1) - 1)
                {
                    this.Col = 0;
                }
                else
                {
                    pond[this.Row, this.Col] = '-';
                    switch (row)
                    {
                        case -1: this.Row = 0; break;
                        case 1: this.Row = pond.GetLength(0) - 1; break;
                    }
                    switch (col)
                    {
                        case -1: this.Col = 0; break;
                        case 1: this.Col = pond.GetLength(1) - 1; break;
                    }
                }
            }
            if (Char.IsLower(pond[this.Row, this.Col]))
            {
                this.Branches.Push(pond[this.Row, this.Col]);
                pond[this.Row, this.Col] = this.Name;
            }
        }
        public bool IsRange(char[,] pond, int row, int col)
        {
            return row >= 0 && row < pond.GetLength(0)
                && col >= 0 && col < pond.GetLength(1);
        }
    }
}