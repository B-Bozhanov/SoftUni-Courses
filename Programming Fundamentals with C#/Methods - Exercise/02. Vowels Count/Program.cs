using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelsCount = GetVowelsCount(word);
            Console.WriteLine(vowelsCount);
        }

        private static int GetVowelsCount(string word)
        {
            int vowelsCount = 0;
            char[] vowels = new char[10] { 'a', 'o', 'u', 'e', 'i', 'A', 'O', 'U', 'E', 'I' };

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        vowelsCount++;
                    }
                }
            }
            return vowelsCount;
        }
    }
}
