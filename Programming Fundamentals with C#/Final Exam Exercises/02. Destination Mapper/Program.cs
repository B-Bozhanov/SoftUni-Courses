using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])([A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            MatchCollection destinations = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            int count = 0;

            foreach (Match item in destinations)
            {
                string currDestination = string.Empty;
                currDestination = item.Groups[2].Value;
                result.Add(item.Groups[2].Value);
                count += currDestination.Count();
            }

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ",result));
            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
