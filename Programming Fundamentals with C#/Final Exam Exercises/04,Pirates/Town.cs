using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Town
    {
        public string TownName { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public Town(string townName, int population, int gold)
        {
            this.TownName = townName;
            this.Population = population;
            this.Gold = gold;
        }

        public bool Plunder(string town, int population, int gold )
        {
            this.Population -= population;
            this.Gold -= gold;

            if (this.Population <= 0 || this.Gold <= 0)
            {
                Console.WriteLine($"{this.TownName} plundered! {this.Gold} gold stolen, {this.Population} citizens killed.");
                Console.WriteLine($"{this.TownName} has been wiped off the map!");
                return true;
            }
                Console.WriteLine($"{this.TownName} plundered! {this.Gold} gold stolen, {this.Population} citizens killed.");
            return false;
        }
        public void Prosper(string town, int gold)
        {
            if (gold < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
                return;
            }
            this.Gold += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {this.TownName} now has {this.Gold} gold.");
        }
    }
}
