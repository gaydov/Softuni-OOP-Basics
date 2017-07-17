using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester GenerateHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);

        switch (type)
        {
            case "Hammer":

                return new HammerHarvester(id, oreOutput, energyRequirement);

            case "Sonic":

                int sonicFactor = int.Parse(arguments[4]);
                return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }

        throw new ArgumentException("Invalid harvester type.");
    }
}

