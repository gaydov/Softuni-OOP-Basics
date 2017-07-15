using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Nation
{
    protected Nation(string name)
    {
        this.Name = name;
        this.Benders = new List<Bender>();
        this.Monuments = new List<Monument>();
    }

    public List<Monument> Monuments { get; set; }

    public List<Bender> Benders { get; set; }

    public string Name { get; set; }

    public double GetTotalPower()
    {
        double powerFromBenders = this.Benders.Sum(b => b.TotalPower);
        int bonusPercentFromMonuments = this.Monuments.Sum(m => m.GetAffinity());

        double bonusPowerFromMonuments = (powerFromBenders / 100) * bonusPercentFromMonuments;

        return powerFromBenders + bonusPowerFromMonuments;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Name} Nation");

        if (this.Benders.Count == 0)
        {
            sb.AppendLine("Benders: None");
        }
        else
        {
            sb.AppendLine("Benders:");
            for (int i = 0; i < this.Benders.Count; i++)
            {
                sb.AppendLine($"###{Benders[i]}");
            }
        }

        if (this.Monuments.Count == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");
            for (int i = 0; i < this.Monuments.Count; i++)
            {
                sb.AppendLine($"###{Monuments[i]}");
            }
        }

        return sb.ToString().Trim();
    }
}
