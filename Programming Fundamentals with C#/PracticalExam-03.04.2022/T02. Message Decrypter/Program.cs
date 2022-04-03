using System;
using System.Text.RegularExpressions;

namespace T02._Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([\$%])([A-Z][a-z]{2,})\1: \[([\d]+)\](\|)\[([\d]+)\]\4\[([\d]+)\]\4$";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match match = Regex.Match(message, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                string currTag = match.Groups[2].Value;
                int firstCh = int.Parse(match.Groups[3].Value);
                int secondCh = int.Parse(match.Groups[5].Value);
                int thirdCh = int.Parse(match.Groups[6].Value);

                Console.WriteLine($"{currTag}: {(char)firstCh}{(char)secondCh}{(char)thirdCh}");
            }
        }
    }
}
