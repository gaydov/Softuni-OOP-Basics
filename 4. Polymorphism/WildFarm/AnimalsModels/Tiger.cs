using System;

public class Tiger : Felime
{
    public Tiger(string name, string type, double weight, string region) 
        : base(name, type, weight, region)
    {
    }

    public override string MakeSound()
    {
        return "ROAAR!!!";
    }

    public override void Eat(Food food)
    {
        if (!food.GetType().Name.Equals("Meat"))
        {
            throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
        }

        base.Eat(food);
    }
}
