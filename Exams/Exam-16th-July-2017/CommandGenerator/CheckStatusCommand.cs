using System.Collections.Generic;

public class CheckStatusCommand : Command
{
    public CheckStatusCommand(DraftManager manager, List<string> args)
        : base(manager, args)
    {
    }

    public override string Execute()
    {
        return this.Manager.Check(this.Args);
    }
}

