using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += this.OreOutput * 200 / 100;
        this.EnergyRequirement += this.EnergyRequirement * 100 / 100;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {this.Id}");
        sb.AppendLine(base.ToString());

        return sb.ToString().Trim();
    }
}
