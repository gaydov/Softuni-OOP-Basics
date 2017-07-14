public abstract class Mammal : Animal
{
    private string livingRegion;

    protected string LivingRegion
    {
        get { return this.livingRegion; }
        set { this.livingRegion = value; }
    }

    protected Mammal(string name, string type, double weight, string region)
        : base(name, type, weight)
    {
        this.LivingRegion = region;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
