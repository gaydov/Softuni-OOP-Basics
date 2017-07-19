using System;
using System.Text;

public abstract class Provider : Worker
{
    private const double minEnergyOutput = 0;
    private const double maxEnergyOutput = 10000;

    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public virtual double EnergyOutput
    {
        get { return this.energyOutput; }

        protected set
        {
            if (value < minEnergyOutput || value > maxEnergyOutput)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }

            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }
}
