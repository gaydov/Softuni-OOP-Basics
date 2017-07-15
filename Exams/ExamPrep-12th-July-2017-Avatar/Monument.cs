public abstract class Monument
{
    protected Monument(string name)
    {
        this.Name = name;
    }

    protected string Name { get; set; }

    public abstract int GetAffinity();
}
