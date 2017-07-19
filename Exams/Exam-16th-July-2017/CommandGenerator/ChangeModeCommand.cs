using System;
using System.Collections.Generic;

public class ChangeModeCommand : Command
{
    public ChangeModeCommand(DraftManager manager, List<string> args)
        : base(manager, args)
    {
    }

    public override string Execute()
    {
        return this.Manager.Mode(this.Args);
    }
}

