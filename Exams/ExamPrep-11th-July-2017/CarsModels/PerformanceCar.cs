using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.HorsePower += this.HorsePower * 50 / 100;
        this.Suspension -= this.Suspension * 25 / 100;
    }

    private List<string> AddOns { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());

        if (this.AddOns.Count > 0)
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", this.AddOns)}");
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }

        return sb.ToString().Trim();
    }

    public override void Tune(int index, string addOn)
    {
        base.Tune(index, addOn);
        this.AddOns.Add(addOn);
    }
}
