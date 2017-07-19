using System.Collections.Generic;

public abstract class Command
{
    private DraftManager manager;
    private List<string> args;

    protected Command(DraftManager manager, List<string> args)
    {
        this.Manager = manager;
        this.Args = args;
    }

    protected List<string> Args
    {
        get { return this.args; }
        set { this.args = value; }
    }

    protected DraftManager Manager
    {
        get { return this.manager; }
        set { this.manager = value; }
    }

    public abstract string Execute();
}

