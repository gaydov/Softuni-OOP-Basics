public static class Constants
{
    // Harvesters' constants:
    internal const double MinEnergyRequirement = 0;
    internal const double MaxEnergyRequirement = 20000;
    internal const double MinOreOutput = 0;
    internal const double OrePercentIncrease = 200 / 100.0;
    internal const double EnergyPercentIncrease = 100 / 100.0;

    // Providers' constants:
    internal const double MinEnergyOutput = 0;
    internal const double MaxEnergyOutput = 10000;
    internal const double PercentIncreaseEnergy = 50 / 100.0;

    // Draft manager constants:
    internal const string InitialSystemMode = "Full";

    internal const double HalfModeEnergyPercentage = 60 / 100.0;
    internal const double HalfModeMinedOrePercentage = 50 / 100.0;
}

