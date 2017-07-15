using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Nation airNation;
    private Nation earthNation;
    private Nation fireNation;
    private Nation waterNation;
    private List<string> warStarters;
    
    public NationsBuilder()
    {
        this.airNation = new AirNation("Air");
        this.earthNation = new EarthNation("Earth");
        this.fireNation = new FireNation("Fire");
        this.waterNation = new WaterNation("Water");
        this.warStarters = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[1];
        string name = benderArgs[2];
        int power = int.Parse(benderArgs[3]);
        double specialParam = double.Parse(benderArgs[4]);

        switch (type)
        {
            case "Air":
                this.airNation.Benders.Add(new AirBender(name, power, specialParam));
                break;

            case "Water":
                this.waterNation.Benders.Add(new WaterBender(name, power, specialParam));
                break;

            case "Fire":
                this.fireNation.Benders.Add(new FireBender(name, power, specialParam));
                break;

            case "Earth":
                this.earthNation.Benders.Add(new EarthBender(name, power, specialParam));
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[1];
        string name = monumentArgs[2];
        int affinity = int.Parse(monumentArgs[3]);

        switch (type)
        {
            case "Air":
                this.airNation.Monuments.Add(new AirMonument(name, affinity));
                break;

            case "Water":
                this.waterNation.Monuments.Add(new WaterMonument(name, affinity));
                break;

            case "Fire":
                this.fireNation.Monuments.Add(new FireMonument(name, affinity));
                break;

            case "Earth":
                this.earthNation.Monuments.Add(new EarthMonument(name, affinity));
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        switch (nationsType)
        {
            case "Air":
                return this.airNation.ToString();

            case "Water":
                return this.waterNation.ToString();

            case "Fire":
                return this.fireNation.ToString();

            case "Earth":
                return this.earthNation.ToString();

            default:
                return null;
        }
    }

    public void IssueWar(string nationsType)
    {
        Nation[] nationsArray = new Nation[] { airNation, fireNation, earthNation, waterNation };
        
        Nation[] losingNations = nationsArray.OrderByDescending(n => n.GetTotalPower()).Skip(1).ToArray();

        foreach (Nation nation in losingNations)
        {
            nation.Benders.Clear();
            nation.Monuments.Clear();
        }

        warStarters.Add(nationsType);
    }

    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();
        int number = 1;

        for (int i = 0; i < warStarters.Count; i++)
        {
            sb.AppendLine($"War {number} issued by {warStarters[i]}");
            number++;
        }

        return sb.ToString().Trim();
    }
}
