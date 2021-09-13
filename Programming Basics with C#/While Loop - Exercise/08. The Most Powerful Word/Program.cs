using System;

namespace _06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //'a', 'e', 'i', 'o', 'u', 'y'
            string words = Console.ReadLine();
            int points = 0;
            string winnerWord = string.Empty;

            while (words != "End of words")
            {
                int currentPoints = 0;
                char firstLetter = ' ';
                for (int i = 0; i < words.Length; i++)
                {
                    currentPoints += words[i];
                }
                firstLetter = words[0];
                if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' 
                    || firstLetter == 'o' || firstLetter == 'u' || firstLetter == 'y' 
                    || firstLetter == 'A' || firstLetter == 'E' || firstLetter == 'I' 
                    || firstLetter == 'O' || firstLetter == 'U' || firstLetter == 'Y')
                {
                    currentPoints *= words.Length;
                }
                else
                {
                    currentPoints /= words.Length;
                }
                              
                if (currentPoints > points)
                {
                    points = currentPoints;
                    winnerWord = words;
                }

                words = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {winnerWord} - {points}");
        }
    }
}
