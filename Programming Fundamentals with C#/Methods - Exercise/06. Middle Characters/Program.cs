using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleChars(text);
        }

        private static void PrintMiddleChars(string text)
        {
            char middleEven = text[text.Length / 2 -1];
            char secondEven = text[text.Length / 2];
            char middlesOdd = text[text.Length / 2];
            
            if (text.Length % 2 == 0)
            {
                Console.Write(middleEven);
                Console.WriteLine(secondEven);
            }
            else
            {
                Console.WriteLine(middlesOdd);
            }
        }
    }
}
