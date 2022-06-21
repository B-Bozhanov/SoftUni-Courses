using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverAtWork
{
    public class Beaver
    {
        public Beaver(int row, int col, char name)
        {
            this.Row = row;
            this.Col = col;
            this.Name = name;
            this.Branches = new Stack<char>();
        }


        public int Row { get; set; }


        public int Col { get; set; }


        public char Name { get; set; }


        public Stack<char> Branches { get; private set; }

        public int BranchesForCollect { get; set; }


        public void Move(char[,] pond, int row, int col)
        {
            pond[this.Row, this.Col] = '-';
            this.Row += row;
            this.Col += col;

            if (!IsRange(pond, this.Row, this.Col))
            {
                this.Row -= row;
                this.Col -= col;
                if (this.Branches.Any())
                {
                    this.Branches.Pop();
                }
            }
            else if (pond[this.Row, this.Col] == 'F')
            {
                pond[this.Row, this.Col] = '-';
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
                this.BranchesForCollect--;
            }
            pond[this.Row, this.Col] = this.Name;
        }
        public bool IsRange(char[,] pond, int row, int col)
        {
            return row >= 0 && row < pond.GetLength(0)
                && col >= 0 && col < pond.GetLength(1);
        }
    }
}
