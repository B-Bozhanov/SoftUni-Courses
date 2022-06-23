using System.Collections.Generic;

namespace Snake
{
    public class Snake
    {
        public Snake(int row, int col, char name)
        {
            this.Row = row;
            this.Col = col;
            this.Name = name;
            this.IsDeath = false;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public char Name { get; set; }
        public int EatenFood { get; set; }
        public bool IsDeath { get; set; }

        public void Move(char[,] field, List<Coordinates> coordinates)
        {
            Coordinates snakeDirect = coordinates[0];
            Coordinates burrows1Cords = new Coordinates(-1, -1);
            Coordinates burrows2Cords = new Coordinates(-1, -1);
            if (coordinates.Count > 1)
            {
                burrows1Cords = coordinates[1];
                burrows2Cords = coordinates[2];
            }

            field[this.Row, this.Col] = '.';
            this.Row += snakeDirect.Row;
            this.Col += snakeDirect.Col;

            if (!IsRange(field, this.Row, this.Col))
            {
                this.IsDeath = true;
                return;
            }

            if (this.Row == burrows1Cords.Row && this.Col == burrows1Cords.Col)
            {
                field[this.Row, this.Col] = '.';
                this.Row = burrows2Cords.Row;
                this.Col = burrows2Cords.Col;
            }
            else if (this.Row == burrows2Cords.Row && this.Col == burrows2Cords.Col)
            {
                field[this.Row, this.Col] = '.';
                this.Row = burrows1Cords.Row;
                this.Col = burrows1Cords.Col;
            }
            else if (field[this.Row, this.Col] == '*')
            {
                this.EatenFood++;
            }

            field[this.Row, this.Col] = this.Name;
        }

        private bool IsRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }
    }
}
