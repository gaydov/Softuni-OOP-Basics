public class FireBender : Bender
{
    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
        this.TotalPower = this.Power * this.HeatAggression;
    }

    public double HeatAggression { get; set; }

    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:F2}";
    }
}
