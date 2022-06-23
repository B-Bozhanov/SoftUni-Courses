using System;
using System.Collections.Generic;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSize, fieldSize];
            FillMatrix(field);

            List<Coordinates> fieldInfo = GetMatrixInfo(field);
            Coordinates snakeCordinates = fieldInfo[0];
            Snake snake = new Snake(snakeCordinates.Row, snakeCordinates.Col, 'S');

            while (true)
            {
                var commands = Console.ReadLine();

                int row = 0;
                int col = 0;
                switch (commands)
                {
                    case "up": row--; break;
                    case "down": row++; break;
                    case "left": col--; break;
                    case "right": col++; break;
                }

                fieldInfo[0].Row = row;
                fieldInfo[0].Col = col;
                snake.Move(field, fieldInfo);

                if (snake.IsDeath)
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {snake.EatenFood}");
                    break;
                }
                else if (snake.EatenFood == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {snake.EatenFood}");
                    break;
                }
            }
            Print(field);
        }
        public static void Print(char[,] field)
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
        public static void FillMatrix(char[,] field)
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
        public static List<Coordinates> GetMatrixInfo(char[,] field)
        {
            List<Coordinates> info = new List<Coordinates>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'S')
                    {
                        info.Add(new Coordinates(row, col));
                    }
                    else if (field[row, col] == 'B')
                    {
                        info.Add(new Coordinates(row, col));
                    }
                }
            }
            return info;
        }
    }
}
