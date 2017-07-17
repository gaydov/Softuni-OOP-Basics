using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider GenerateProvider(List<string> args)
    {
        string type = args[0];
        string id = args[1];
        double energyOutput = double.Parse(args[2]);

        switch (type)
        {
            case "Pressure":
                return new PressureProvider(id, energyOutput);

            case "Solar":
                return new SolarProvider(id, energyOutput);

        }

        throw new ArgumentException("Invalid provider type.");
    }
}

