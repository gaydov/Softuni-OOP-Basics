using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_16th_July_2017
{
    public class Launcher
    {
        public static void Main()
        {
            DraftManager manager = new DraftManager();

            string input = Console.ReadLine();

            while (true)
            {
                List<string> args = input.Split().ToList();
                string command = args[0];
                string result = string.Empty;

                switch (command)
                {
                    case "RegisterHarvester":
                        result = manager.RegisterHarvester(args.Skip(1).ToList());
                        break;

                    case "RegisterProvider":
                        result = manager.RegisterProvider(args.Skip(1).ToList());
                        break;

                    case "Day":
                        result = manager.Day();
                        break;

                    case "Mode":
                        result = manager.Mode(args.Skip(1).ToList());
                        break;

                    case "Check":
                        result = manager.Check(args.Skip(1).ToList());
                        break;

                    case "Shutdown":
                        Console.WriteLine(manager.ShutDown());
                        return;
                }

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
