public abstract class Mammal : Animal
{
    private string livingRegion;

    protected Mammal(string name, string type, double weight, string region)
        : base(name, type, weight)
    {
        this.LivingRegion = region;
    }

    protected string LivingRegion
    {
        get { return this.livingRegion; }
        set { this.livingRegion = value; }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
