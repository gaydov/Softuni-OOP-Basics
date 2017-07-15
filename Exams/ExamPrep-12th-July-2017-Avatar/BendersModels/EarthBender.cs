public class EarthBender : Bender
{
    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
        this.TotalPower = this.Power * this.GroundSaturation;
    }

    public double GroundSaturation { get; set; }

    public override string ToString()
    {
        return $"Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroundSaturation:F2}";
    }
}
