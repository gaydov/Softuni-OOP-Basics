using System.Threading;

public class WaterBender : Bender
{
    public WaterBender(string name, int power, double waterClarity)
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
        this.TotalPower = this.Power * this.WaterClarity;
    }

    public double WaterClarity { get; set; }

    public override string ToString()
    {
        return $"Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:F2}";
    }
}
