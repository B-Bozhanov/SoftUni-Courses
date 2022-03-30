using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] text = command.Split();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

           
            foreach (var item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!dictionary.ContainsKey(item[i]))
                    {
                        dictionary.Add(item[i], 0);
                    }
                    dictionary[item[i]]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
