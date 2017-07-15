using System.Text;

public abstract class Car
{
    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.HorsePower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public int Durability { get; set; }

    public int Suspension { get; set; }

    public int Acceleration { get; set; }

    public int HorsePower { get; set; }

    public int YearOfProduction { get; set; }

    public string Model { get; set; }

    public string Brand { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

        return sb.ToString();
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.HorsePower += tuneIndex;
        this.Suspension += tuneIndex * 50 / 100;
    }
}
