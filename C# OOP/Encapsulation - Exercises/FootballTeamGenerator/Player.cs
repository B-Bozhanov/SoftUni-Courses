using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Player
    {
        private string name;
        private Dictionary<string, int> stats;

        public Player(string name, Dictionary<string, int> stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public Dictionary<string, int> Stats
        {
            get => stats;
            private set
            {
                foreach (var stat in value)
                {
                    if (stat.Value < 0 || stat.Value > 100)
                    {
                        throw new InvalidOperationException($"{stat.Key} should be between 0 and 100.");
                    }
                }
                this.stats = value;
            }
        }
        public int AverageSkills { get => CalculateSkillLevel(); }

        private int CalculateSkillLevel()
        {
            var average = (int)Math.Round(stats.Values.Average());
            return average;
        }
    }
}
