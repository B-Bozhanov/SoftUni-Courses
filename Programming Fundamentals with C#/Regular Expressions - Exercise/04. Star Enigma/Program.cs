using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPatern = @"[STARstar]";
            string encryptedPatern = @"@([A-Za-z]+)([^@!:>\-]*):([0-9]+)([^@!:>\-]*)!([AD])!([^@!:>\-]*)->[0-9]+";

            int n = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string currentInput = string.Empty;
                MatchCollection inputCount = Regex.Matches(input, firstPatern);
                int count = inputCount.Count;

                for (int j = 0; j < input.Length; j++)
                {
                    currentInput += (char)(input[j] - count);
                }

                MatchCollection message = Regex.Matches(currentInput, encryptedPatern);
                string planetName = string.Empty;
                string action = string.Empty;
                foreach (Match item in message)
                {
                    planetName = item.Groups[1].Value;
                    action = item.Groups[5].Value;
                }

                if (action == "A")
                {
                    attacked.Add(planetName);
                }
                else if (action == "D")
                {
                    destroyed.Add(planetName);
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count != 0)
            {
                foreach (var item in attacked.OrderBy(x =>x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count != 0)
            {
                foreach (var item in destroyed.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
