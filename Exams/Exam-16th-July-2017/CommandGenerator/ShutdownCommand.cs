using System;
using System.Collections.Generic;

public class ShutdownCommand : Command
{
    public ShutdownCommand(DraftManager manager, List<string> args)
        : base(manager, args)
    {
    }

    public override string Execute()
    {
        return this.Manager.ShutDown();
    }
}

