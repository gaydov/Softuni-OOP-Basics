using System;

namespace ExamPrep_11th_July_2017
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            CarManager manager = new CarManager();

            while (!input.Equals("Cops Are Here"))
            {
                string[] args = input.Split();
                string command = args[0];

                switch (command)
                {
                    case "register":
                        manager.Register(int.Parse(args[1]), args[2], args[3], args[4], int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7]), int.Parse(args[8]), int.Parse(args[9]));
                        break;

                    case "check":
                        Console.WriteLine(manager.Check(int.Parse(args[1])));
                        break;

                    case "open":

                        if (args.Length == 6)
                        {
                            manager.Open(int.Parse(args[1]), args[2], int.Parse(args[3]), args[4], int.Parse(args[5]));
                            break;
                        }
                        else // special race - one parameter more
                        {
                            manager.Open(int.Parse(args[1]), args[2], int.Parse(args[3]), args[4], int.Parse(args[5]), int.Parse(args[6]));
                            break;
                        }

                    case "participate":
                        manager.Participate(int.Parse(args[1]), int.Parse(args[2]));
                        break;

                    case "start":
                        Console.WriteLine(manager.Start(int.Parse(args[1])));
                        break;

                    case "park":
                        manager.Park(int.Parse(args[1]));
                        break;

                    case "unpark":
                        manager.Unpark(int.Parse(args[1]));
                        break;

                    case "tune":
                        manager.Tune(int.Parse(args[1]), args[2]);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
