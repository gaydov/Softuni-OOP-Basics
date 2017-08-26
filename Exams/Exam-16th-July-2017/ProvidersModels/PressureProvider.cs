using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
    }

    public override double EnergyOutput
    {
        get
        {
            return base.EnergyOutput;
        }

        protected set
        {
            base.EnergyOutput = value + (value * Constants.PercentIncreaseEnergy);
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Pressure Provider - {this.Id}");
        sb.AppendLine(base.ToString());

        return sb.ToString().Trim();
    }
}
