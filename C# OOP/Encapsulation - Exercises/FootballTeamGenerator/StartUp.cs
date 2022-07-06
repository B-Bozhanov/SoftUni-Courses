using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    var inputArgs = input.Trim().Split(';', StringSplitOptions.RemoveEmptyEntries);
                    var action = inputArgs[0];
                    var currentTeam = inputArgs[1];

                    if (action == "Team")
                    {
                        if (!teams.ContainsKey(currentTeam))
                        {
                            teams[currentTeam] = new Team(currentTeam);
                        }
                    }
                    else if (action == "Add")
                    {
                        var playerName = inputArgs[2];
                        var playerStats = new Dictionary<string, int>
                    {
                        {"Endurance", int.Parse(inputArgs[3]) },
                        {"Sprint", int.Parse(inputArgs[4]) },
                        {"Dribble", int.Parse(inputArgs[5]) },
                        {"Passing", int.Parse(inputArgs[6]) },
                        {"Shooting", int.Parse(inputArgs[7]) }
                    };
                        if (!teams.ContainsKey(currentTeam))
                        {
                            Console.WriteLine($"Team {currentTeam} does not exist.");
                            input = Console.ReadLine();
                            continue;
                        }

                        teams[currentTeam].Add(new Player(playerName, playerStats));
                    }
                    else if (action == "Remove")
                    {
                        var playerName = inputArgs[2];
                        if (!teams[currentTeam].Remove(playerName))
                        {
                            Console.WriteLine($"Player {playerName} is not in {currentTeam} team.");
                        }
                    }
                    else if (action == "Rating")
                    {
                        if (!teams.ContainsKey(currentTeam))
                        {
                            Console.WriteLine($"Team {currentTeam} does not exist.");
                            input = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"{currentTeam} - {teams[currentTeam].Rating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}
