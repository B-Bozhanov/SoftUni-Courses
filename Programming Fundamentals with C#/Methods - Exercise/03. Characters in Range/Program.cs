using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = Console.ReadLine()[0];
            char secondSymbol = Console.ReadLine()[0];
            if (firstSymbol > secondSymbol)
            {
                char reverse = firstSymbol;
                firstSymbol = secondSymbol;
                secondSymbol = reverse;
            }
            PrintCharBetweenSymbols(firstSymbol, secondSymbol);
        }
        private static void PrintCharBetweenSymbols(char start, char end)
        {
            for (int i = start + 1; i < end ; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
