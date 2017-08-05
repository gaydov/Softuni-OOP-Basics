using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    public override string ToString()
    {
        if (this.bag.Count > 0)
        {
            return $"{this.name} - {string.Join(", ", this.bag.Select(product => product.Name))}";
        }
        return $"{this.name} - Nothing bought";
    }

    public string Name
    {
        get { return this.name; }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Name cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<Product> Bag
    {
        get { return this.bag; }
        set { this.bag = value; }
    }
}

