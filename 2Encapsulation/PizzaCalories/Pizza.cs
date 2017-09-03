using System;
using System.Collections.Generic;

public class Pizza
{
    private string name;
    private List<Topping> toppings;
    private Dough dough;
    private int toppingsCount;

    public Pizza(string name, int toppingsCount)
    {
        this.Name = name;
        this.Toppings = new List<Topping>();
        this.ToppingsCount = toppingsCount;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public Dough Dough
    {
        set { this.dough = value; }
    }

    public int ToppingsCount
    {
        get
        {
            return this.toppingsCount;
        }

        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppingsCount = value;
        }
    }

    private List<Topping> Toppings
    {
        set { this.toppings = value; }
    }

    public void AddToping(string type, double weight)
    {
        this.toppings.Add(new Topping(type, weight));
    }

    public double CalcTotalCalories()
    {
        double sum = 0;
        sum += this.dough.CalcDoughCalories();

        foreach (Topping topping in this.toppings)
        {
            sum += topping.CalcToppingCalories();
        }

        return sum;
    }
}