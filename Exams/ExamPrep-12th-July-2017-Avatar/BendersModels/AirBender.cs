
public class AirBender : Bender
{
    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
        this.TotalPower = this.Power * this.AerialIntegrity;
    }

    public double AerialIntegrity { get; set; }

    public override string ToString()
    {
        return $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:F2}";
    }
}
