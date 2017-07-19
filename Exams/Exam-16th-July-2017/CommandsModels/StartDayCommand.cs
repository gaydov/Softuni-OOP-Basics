using System.Collections.Generic;

public class StartDayCommand : Command
{
    public StartDayCommand(DraftManager manager, List<string> args) 
        : base(manager, args)
    {
    }

    public override string Execute()
    {
        return this.Manager.Day();
    }
}

