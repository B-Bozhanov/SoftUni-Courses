using Formula1.Models.Contracts;
namespace Formula1.Models
{
    using Formula1.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Race : IRace
    {
        private ICollection<IPilot> pilots;
        private string raceName;
        private int numberOfLaps;

        private Race()
        {
            this.pilots = new List<IPilot>();
        }
        public Race(string raceName, int numberOfLaps) : this()
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            this.TookPlace = false;
        }
        public string RaceName
        {
            get => this.raceName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidRaceName, value));
                }
                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get => this.numberOfLaps;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidLapNumbers, value));
                }
                this.numberOfLaps = value;
            }
        }

        public bool TookPlace { get; set; } // !!!

        public ICollection<IPilot> Pilots { get => this.pilots; }

        public void AddPilot(IPilot pilot)
        {
            this.pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            var info = new StringBuilder();
            info.AppendLine($"The { this.raceName } race has:");
            info.AppendLine($"Participants: {this.pilots.Count}");
            info.AppendLine($"Number of laps: {this.NumberOfLaps }");
            info.AppendLine($"Took place {this.TookPlace}");
            return info.ToString().Trim();
        }
    }
}
