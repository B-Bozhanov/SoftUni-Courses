﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    internal class Hero
    {
        public Hero(string userName, int level)
        {
            Username = userName;
            Level = level;
        }

        public string Username { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
