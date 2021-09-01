using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char vowels = ' ';
            int totalSum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char vowel = word[i];
                switch (vowel)
                {
                    case 'a':
                        totalSum += 1;break;
                    case 'e':
                        totalSum += 2; break;
                    case 'i':
                        totalSum += 3; break;
                    case 'o':
                        totalSum += 4; break;
                    case 'u':
                        totalSum += 5; break;
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
