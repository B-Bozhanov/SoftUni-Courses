using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> result =  new Dictionary<char, int>();

            foreach (var ch in input)
            {
                if (!result.ContainsKey(ch))
                {
                    result.Add(ch, 0);
                }
                result[ch]++;
            }
            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
