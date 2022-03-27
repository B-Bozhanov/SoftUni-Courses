using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Raed the input.
            int n = int.Parse(Console.ReadLine());

            List<HeroesInfo> heroesInfo = new List<HeroesInfo>();

            for (int i = 0; i < n; i++)
            {
                string[] heroesArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = heroesArgs[0];
                int hp = int.Parse(heroesArgs[1]);
                int mp = int.Parse(heroesArgs[2]);

                if (hp > 100)
                {
                    hp = 100;
                }
                if (mp > 200)
                {
                    mp = 200;
                }

                heroesInfo.Add(new HeroesInfo(name, hp, mp));
            }

            string commands = Console.ReadLine();
            while (commands != "End")
            {
                string[] cmdArgs = commands
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string name = cmdArgs[1];

                HeroesInfo currHero = heroesInfo.SingleOrDefault(x => x.Name == name);

                if (action == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    currHero.CastSpell(mpNeeded, spellName);
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    if (currHero.TakeDamage(damage, attacker))
                    {
                        heroesInfo.Remove(currHero);
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    currHero.Recharge(amount);
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    currHero.Heal(amount);
                }


                commands = Console.ReadLine();
            }

            foreach (var hero in heroesInfo)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }
}
