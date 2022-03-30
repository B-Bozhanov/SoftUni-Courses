using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Plant_Discovery
{
    class Program
    {
        public static object Reex { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, double[]> plants = new Dictionary<string, double[]>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string name = input[0];
                int rarity = int.Parse(input[1]);

                if (!plants.ContainsKey(name))
                {
                    plants.Add(name, new double[4]);
                    plants[name][0] = rarity;
                }
                else
                {
                    plants[name][0] = rarity;                                 // Update rarity if the given plant is already exist in double Array on index[0] in the Dictionary.
                }

            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string pattern = @"[A-Za-z0-9]+";                                 // Split command
                List<string> commandArgs = new List<string>();

                MatchCollection split = Regex.Matches(command, pattern);
                foreach (Match item in split)
                {
                    commandArgs.Add(item.Value);                               // Added the splitted command to new List
                }
                string action = commandArgs[0];
                string name = commandArgs[1];
                if (!plants.ContainsKey(name))                                 // If the given plant name is invalid
                {
                    Console.WriteLine("error");
                    command = Console.ReadLine();
                    continue;
                }

                if (action == "Rate")
                {
                    int rating = int.Parse(commandArgs[2]);                        // Take rate value from the command
                    plants[name][1] += rating;                                     // Added rating to the Dictionary double array in index[1]
                    plants[name][2]++;                                             // Index [2] in the same array is a couter to the same plant
                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(commandArgs[2]);                    // Take new rariry value from the command and Update it.
                    plants[name][0] = newRarity;
                }
                else if (action == "Reset")
                {
                    plants[name][1] = 0;                                         // Reset rating and counter.        
                    plants[name][2] = 0;
                }

                if (plants[name][1] == 0 && plants[name][2] == 0)                //  If rating and counter are zero, average raiting is also equal to zero.
                {
                    plants[name][3] = 0;
                }
                else
                {
                    plants[name][3] = plants[name][1] / plants[name][2];         // Else Calculate average rating.
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[3]))   // Sort and print Dictionary
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[3]:f2}");
            }
        }
    }
}
