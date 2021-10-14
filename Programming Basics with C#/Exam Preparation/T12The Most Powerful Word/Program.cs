using System;

namespace T12The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            double maxPoints = 0;
            string winnerWord = " ";

            while (word != "End of words")
            {
                double curentWordPoints = 0;
                char ch = ' ';

                for (int i = 0; i < word.Length; i++)
                {
                    curentWordPoints += (int)word[i];

                    if (i == 0)
                    {
                        ch = word[0];
                    }
                }
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'Y':
                        curentWordPoints *= word.Length;
                        break;
                    default:
                        curentWordPoints = Math.Floor(curentWordPoints / word.Length);
                        break;
                }

                if (curentWordPoints >= maxPoints)
                {
                    maxPoints = curentWordPoints;
                    winnerWord = word;
                }

                word = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {winnerWord} - {maxPoints}");
        }
    }
}



