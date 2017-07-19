using System;
using System.Text;

public abstract class Provider : Worker
{
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
            if (value < Constants.MinEnergyOutput || value > Constants.MaxEnergyOutput)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
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
