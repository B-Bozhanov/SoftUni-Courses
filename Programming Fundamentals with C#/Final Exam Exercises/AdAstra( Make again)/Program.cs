using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace AdAstra__Make_again_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            string patern = @"([#|])(?<item>[A-Za-z *]{3,})\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]+)\1";
            int caloriesPerDay = 2000;
            int days = 0;
            int calories = 0;

            MatchCollection food = Regex.Matches(input, patern);

            foreach (Match match in food)
            {
                calories += int.Parse(match.Groups["calories"].Value);
            }
            days = calories / caloriesPerDay;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in food)
            {
                Console.Write($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
                Console.WriteLine();
            }
        }
    }
}