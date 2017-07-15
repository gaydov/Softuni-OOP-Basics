using System.Text;

public class ShowCar : Car
{
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public int Stars { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());

        sb.AppendLine($"{Stars} *");

        return sb.ToString().Trim();
    }

    public override void Tune(int index, string addOn)
    {
        base.Tune(index, addOn);
        this.Stars += index;
    }
}
