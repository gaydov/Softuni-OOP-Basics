public class Tyre
{
    private double pressure = 0;
    private int age = 0;

    public Tyre(double pressure, int age)
    {
        this.pressure = pressure;
        this.age = age;
    }

    public double Pressure
    {
        get { return this.pressure; }
        set { this.pressure = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}