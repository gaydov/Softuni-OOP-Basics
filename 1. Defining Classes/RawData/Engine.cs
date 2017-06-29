
public class Engine
{
    private int engineSpeed = 0;
    private int enginePower = 0;

    public Engine(int speed, int power)
    {
        this.engineSpeed = speed;
        this.enginePower = power;
    }

    public int EngineSpeed
    {
        get { return this.engineSpeed; }
        set { this.engineSpeed = value; }
    }

    public int EnginePower
    {
        get { return this.enginePower; }
        set { this.enginePower = value; }
    }
}

