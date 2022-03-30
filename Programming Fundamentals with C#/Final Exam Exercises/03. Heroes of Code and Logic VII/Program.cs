using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hitPoints = int.Parse(input[1]);
                int manaPoints = int.Parse(input[2]);

                if (!heroes.ContainsKey(name))
                {
                    heroes.Add(name, new int[2]);
                }
                if (hitPoints > 100)
                {
                    hitPoints = 100;
                }
                if (manaPoints > 200)
                {
                    manaPoints = 200;
                }
                heroes[name][0] += hitPoints;
                heroes[name][1] += manaPoints;
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" - ");
                string action = commandArgs[0];
                string heroName = commandArgs[1];
                int MP = heroes[heroName][1];
                int HP = heroes[heroName][0];

                if (action == "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];
                    if (MP >= manaPointsNeeded)
                    {
                        MP -= manaPointsNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(commandArgs[2]);
                    string atacker = commandArgs[3];
                    HP -= damage;
                    if (HP <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {atacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {atacker} and now has {HP} HP left!");
                    }
                }
                else if (action == "Recharge")
                {
                    int amaunt = int.Parse(commandArgs[2]);
                    if (MP + amaunt > 200)
                    {
                        int currentPoints = 200 - MP;
                        Console.WriteLine($"{heroName} recharged for {currentPoints} MP!");
                        MP = 200;
                    }
                    else
                    {
                        MP += amaunt;
                        Console.WriteLine($"{heroName} recharged for {amaunt} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    int amaunt = int.Parse(commandArgs[2]);
                    if (HP + amaunt > 100)
                    {
                        int currentPoints = 100 - HP;
                        Console.WriteLine($"{heroName} healed for {currentPoints} HP!");
                        HP = 100;
                    }
                    else
                    {
                        HP += amaunt;
                        Console.WriteLine($"{heroName} healed for {amaunt} HP!");
                    }
                }
                if (heroes.ContainsKey(heroName))
                {
                    heroes[heroName][1] = MP;
                    heroes[heroName][0] = HP;
                }

                command = Console.ReadLine();
            }

            foreach (var item in heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}
