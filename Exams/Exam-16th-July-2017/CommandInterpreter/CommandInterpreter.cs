using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    public void TryExecuteCommand()
    {
        DraftManager draftManager = new DraftManager();
        string input = Console.ReadLine();
        string result = string.Empty;

        while (true)
        {
            List<string> inputArgs = input.Split().ToList();
            string commandName = inputArgs[0];
            List<string> commandArgs = inputArgs.Skip(1).ToList();
            Command cmdToBeExecuted = null;

            switch (commandName)
            {
                case "RegisterHarvester":
                    cmdToBeExecuted = new RegisterHarvesterCommand(draftManager, commandArgs);
                    break;

                case "RegisterProvider":
                    cmdToBeExecuted = new RegisterProviderCommand(draftManager, commandArgs);
                    break;

                case "Day":
                    cmdToBeExecuted = new StartDayCommand(draftManager, commandArgs);
                    break;

                case "Mode":
                    cmdToBeExecuted = new ChangeModeCommand(draftManager, commandArgs);
                    break;

                case "Check":
                    cmdToBeExecuted = new CheckStatusCommand(draftManager, commandArgs);
                    break;

                case "Shutdown":
                    cmdToBeExecuted = new ShutdownCommand(draftManager, commandArgs);
                    Console.WriteLine(cmdToBeExecuted.Execute());
                    return;
            }

            result = cmdToBeExecuted.Execute();
            Console.WriteLine(result);

            input = Console.ReadLine();
        }
    }
}

