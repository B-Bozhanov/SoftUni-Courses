using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T01._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#\$\^])\1{5,9}";
            string[] tickets = Console.ReadLine()
                 .Split(",", StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                string currTicket = tickets[i];
                if (currTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string left = currTicket.Substring(0, currTicket.Length / 2);
                string right = currTicket.Substring(currTicket.Length / 2);
                Match matchLeft = Regex.Match(left, pattern);
                Match matchRight = Regex.Match(right, pattern);

                if (matchLeft.Success && matchRight.Success)
                {
                    int minLeft = matchLeft.Value.Length;
                    int minRight = matchRight.Value.Length;
                    int result = Math.Min(minLeft, minRight);
                   
                    if (result == 10)
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - {result}{matchLeft.Groups[1].Value} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - {result}{matchLeft.Groups[1].Value}");
                    }
                    continue;
                }
                Console.WriteLine($"ticket \"{currTicket}\" - no match");
            }
        }
    }
}