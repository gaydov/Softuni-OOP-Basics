using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Launcher
    {
        public static void Main()
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            string line = Console.ReadLine();

            while (!line.Equals("END"))
            {
                string[] args = line.Split(';');
                string cmd = args[0];

                try
                {
                    switch (cmd)
                    {
                        case "Team":
                            teams.Add(args[1], new Team(args[1]));
                            break;

                        case "Add":
                            AddPlayerToTeam(teams, args[1], args[2],
                                int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7])
                            );
                            break;

                        case "Remove":
                            RemovePlayerFromTeam(teams, args[1], args[2]);
                            break;

                        case "Rating":
                            PrintTeamRating(teams, args[1]);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }
        }

        private static void PrintTeamRating(Dictionary<string, Team> teams, string teamName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }

            Console.WriteLine(teams[teamName]);
        }

        private static void RemovePlayerFromTeam(Dictionary<string, Team> teams, string teamName, string playerName)
        {
            teams[teamName].RemovePlayer(playerName);
        }

        private static void AddPlayerToTeam(Dictionary<string, Team> teams, string teamName, string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            Player currentPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
            teams[teamName].AddPlayer(currentPlayer);
        }
    }
}
