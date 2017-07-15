public abstract class Bender
{
    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public double TotalPower { get; set; }

    protected int Power { get; set; }

    protected string Name { get; set; }
}
