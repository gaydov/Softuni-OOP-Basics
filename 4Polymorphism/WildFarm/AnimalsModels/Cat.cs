public class Cat : Felime
{
    private string breed;

    public Cat(string name, string type, double weight, string region, string breed)
        : base(name, type, weight, region)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public override string MakeSound()
    {
        return "Meowwww";
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}