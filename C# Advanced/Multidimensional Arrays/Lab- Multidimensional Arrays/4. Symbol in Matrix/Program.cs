using System;
using System.Linq;

namespace Bricks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] symbols = new char[n, n];

            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                string currentSymbols = Console.ReadLine();
                for (int j = 0; j < symbols.GetLength(1); j++)
                {
                    symbols[i, j] = currentSymbols[j];
                }
            }
            char seekedSymbol = Console.ReadLine()[0];
            bool IsTrue = false;
            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                for (int j = 0; j < symbols.GetLength(1); j++)
                {
                    if (symbols[i, j] == seekedSymbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        IsTrue = true;
                        return;
                    }
                }
            }
            if (IsTrue == false)
            {
                Console.WriteLine($"{seekedSymbol} does not occur in the matrix");
            }
        }
    }
}
