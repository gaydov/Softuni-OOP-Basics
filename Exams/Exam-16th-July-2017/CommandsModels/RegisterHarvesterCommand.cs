using System.Collections.Generic;

public class RegisterHarvesterCommand : Command
{
    public RegisterHarvesterCommand(DraftManager manager, List<string> args)
        : base(manager, args)
    {
    }

    public override string Execute()
    {
        return this.Manager.RegisterHarvester(this.Args);
    }
}