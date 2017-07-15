using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep_12th_July_2017_Avatar
{
    public class Launcher
    {
        public static void Main()
        {
            NationsBuilder nationsBuilder = new NationsBuilder();

            string input = Console.ReadLine();

            while (true)
            {
                List<string> args = input.Split().ToList();
                string command = args[0];

                switch (command)
                {
                    case "Bender":
                        nationsBuilder.AssignBender(args);
                        break;

                    case "Monument":
                        nationsBuilder.AssignMonument(args);
                        break;

                    case "Status":
                        string nationType = args[1];
                        Console.WriteLine(nationsBuilder.GetStatus(nationType));
                        break;

                    case "War":
                        string nation = args[1];
                        nationsBuilder.IssueWar(nation);
                        break;

                    case "Quit":
                        Console.WriteLine(nationsBuilder.GetWarsRecord());
                        return;
                }

                input = Console.ReadLine();
            }
        }
    }
}
