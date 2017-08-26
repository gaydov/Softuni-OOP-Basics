using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private readonly Dictionary<string, Harvester> harvesters;
    private readonly Dictionary<string, Provider> providers;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private string modeType;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;
        this.modeType = Constants.InitialSystemMode;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];

        try
        {
            this.harvesters.Add(id, HarvesterFactory.GenerateHarvester(arguments));
            return $"Successfully registered {type} Harvester - {id}";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];

        try
        {
            this.providers.Add(id, ProviderFactory.GenerateProvider(arguments));
            return $"Successfully registered {type} Provider - {id}";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string Day()
    {
        double dailyProvidedEnergy = this.providers.Values.Sum(p => p.EnergyOutput);
        double requiredEnergyPerMode = 0;
        double minedOrePerMode = 0;
        double dailyMinedOre = 0;

        switch (this.modeType)
        {
            case "Full":

                requiredEnergyPerMode = this.harvesters.Values.Sum(h => h.EnergyRequirement);
                minedOrePerMode = this.harvesters.Values.Sum(h => h.OreOutput);
                break;

            case "Half":

                requiredEnergyPerMode = this.harvesters.Values.Sum(h => h.EnergyRequirement * Constants.HalfModeEnergyPercentage);
                minedOrePerMode = this.harvesters.Values.Sum(h => h.OreOutput * Constants.HalfModeMinedOrePercentage);
                break;
        }

        this.totalStoredEnergy += dailyProvidedEnergy;

        // In "Energy" mode there is no mining, only the providers work
        if (!this.modeType.Equals("Energy")) 
        {
            // Mining process
            if (requiredEnergyPerMode <= this.totalStoredEnergy)
            {
                this.totalStoredEnergy -= requiredEnergyPerMode;
                dailyMinedOre += minedOrePerMode;
                this.totalMinedOre += dailyMinedOre;
            }
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {dailyProvidedEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {dailyMinedOre}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        string mode = arguments[0];

        this.modeType = mode;

        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];

        if (this.harvesters.ContainsKey(id))
        {
            return this.harvesters[id].ToString();
        }

        if (this.providers.ContainsKey(id))
        {
            return this.providers[id].ToString();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }
}
