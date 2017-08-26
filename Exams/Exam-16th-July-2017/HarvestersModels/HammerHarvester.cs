using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
    }

    public override double OreOutput
    {
        get
        {
            return base.OreOutput;
        }

        protected set
        {
            base.OreOutput = value + (value * Constants.OrePercentIncrease);
        }
    }

    public override double EnergyRequirement
    {
        get
        {
            return base.EnergyRequirement;
        }

        protected set
        {
            base.EnergyRequirement = value + (value * Constants.EnergyPercentIncrease);
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {this.Id}");
        sb.AppendLine(base.ToString());

        return sb.ToString().Trim();
    }
}
