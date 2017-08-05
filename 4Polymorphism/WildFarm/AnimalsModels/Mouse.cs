using System;

public class Mouse : Mammal
{
    public Mouse(string name, string type, double weight, string region)
        : base(name, type, weight, region)
    {
    }

    public override string MakeSound()
    {
        return "SQUEEEAAAK!";
    }

    public override void Eat(Food food)
    {
        if (!food.GetType().Name.Equals("Vegetable"))
        {
            throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
        }

        base.Eat(food);
    }
}
