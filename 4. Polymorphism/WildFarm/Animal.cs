public abstract class Animal
{
    private string name;
    private string type;
    private double weight;
    private int foodEaten;

    protected Animal(string name, string type, double weight)
    {
        this.Name = name;
        this.Type = type;
        this.Weight = weight;
    }

    protected int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }

    protected double Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    protected string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    protected string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract string MakeSound();

    public virtual void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.FoodEaten}]";
    }
}
