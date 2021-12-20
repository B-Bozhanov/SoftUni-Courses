using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> targetVillage = new Dictionary<string, int[]>();
            string firstCommand = Console.ReadLine();

            while (firstCommand != "Sail")
            {
                string[] commandArgs = firstCommand.Split("||");
                string town = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);

                if (!targetVillage.ContainsKey(town)) 
                {
                    targetVillage.Add(town, new int[2]);
                }
                targetVillage[town][0] += population;
                targetVillage[town][1] += gold;

                firstCommand = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();
            while (secondCommand != "End")
            {
                string[] commandArgs = secondCommand.Split("=>");
                string action = commandArgs[0];
                if (secondCommand == "Plunder")
                {
                    string town = commandArgs[1];
                    int population = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    targetVillage[town][0] -= population;
                    targetVillage[town][1] -= gold;
                    if (targetVillage[town][0] <= 0 || targetVillage[town][1] <= 0)
                    {
                        targetVillage.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                    else
                    {
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");
                    }
                }
                else if (secondCommand == "Prosper")
                {
                    string town = commandArgs[1];
                    int gold = int.Parse(commandArgs[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        secondCommand = Console.ReadLine();
                        continue;
                    }
                    targetVillage[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {targetVillage[town][1]} gold.");
                }


                secondCommand = Console.ReadLine();
            }
            Console.WriteLine($"Ahoy, Captain! There are {targetVillage.Count} wealthy settlements to go to:");
            if (targetVillage.Count <= 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                foreach (var item in targetVillage.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
        }
    }
}
