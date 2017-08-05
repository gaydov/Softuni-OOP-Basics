using System;

namespace FirstAndReserveTeams
{
    public class Launcher
    {
        public static void Main()
        {
            int playersCount = int.Parse(Console.ReadLine());
            Team team = new Team("Levski");

            for (int i = 0; i < playersCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person currentPerson = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));
                team.AddPlayer(currentPerson);
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
        }
    }
}
