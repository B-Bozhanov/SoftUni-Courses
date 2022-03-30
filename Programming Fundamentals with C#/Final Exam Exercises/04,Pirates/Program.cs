using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();

            string firstCommand = Console.ReadLine();
            while (firstCommand != "Sail")
            {
                string[] commandArgs = firstCommand.Split("||");

                string town = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);
                towns.Add(new Town(town, population, gold));

                firstCommand = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();
            while (secondCommand != "End")
            {
                string[] commandArgs = secondCommand.Split("=>");

                string action = commandArgs[0];
                string town = commandArgs[1];
                Town currTown = towns.SingleOrDefault(x => x.TownName == town);

                if (action == "Plunder")
                {
                    int population = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    if (currTown.Plunder(town, population, gold))
                    {
                        towns.Remove(currTown);
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(commandArgs[2]);
                    currTown.Prosper(town, gold);
                }

                secondCommand = Console.ReadLine();
            }
            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            if (towns.Count <= 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                foreach (var item in towns.OrderByDescending(x => x.Gold).ThenBy(x => x.TownName))
                {
                    Console.WriteLine($"{item.TownName} -> Population: {item.Population} citizens, Gold: {item.Gold} kg");
                }
            }
        }
    }
}
