using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Team
    {
        private string name;
        private int rating;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Rating
        {
            get => CalculateRating();
        }

        private int CalculateRating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            return this.rating = players.Sum(p => p.AverageSkills) / this.players.Count;
        }
        public void Add(Player player)
        {
            this.players.Add(player);
        }
        public bool Remove(string player)
        {
            var currentPlayer = players.FirstOrDefault(p => p.Name == player);
            return this.players.Remove(currentPlayer);
        }
    }
}
