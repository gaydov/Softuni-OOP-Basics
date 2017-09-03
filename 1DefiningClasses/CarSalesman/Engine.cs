public class Engine
{
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public string Displacement
    {
        get
        {
            return this.displacement;
        }

        set
        {
            if (value == null)
            {
                this.displacement = "n/a";
            }
            else
            {
                this.displacement = value;
            }
        }
    }

    public string Efficiency
    {
        get
        {
            return this.efficiency;
        }

        set
        {
            if (value == null)
            {
                this.efficiency = "n/a";
            }
            else
            {
                this.efficiency = value;
            }
        }
    }

    public override string ToString()
    {
        return string.Empty;
    }
}