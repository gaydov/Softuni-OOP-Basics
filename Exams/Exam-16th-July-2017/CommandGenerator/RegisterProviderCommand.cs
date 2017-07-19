using System;
using System.Collections.Generic;

public class RegisterProviderCommand : Command
{
    public RegisterProviderCommand(DraftManager manager, List<string> args)
        : base(manager, args)
    {
    }

    public override string Execute()
    {
        return this.Manager.RegisterProvider(this.Args);
    }
}

