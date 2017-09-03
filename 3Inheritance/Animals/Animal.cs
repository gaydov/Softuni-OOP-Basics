using System;
using System.Text;

public abstract class Animal : ProduceSound
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        private set
        {
            if (value < 0 || string.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.gender;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.gender = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.GetType()}");
        sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
        sb.Append($"{this.MakeSound()}");

        return sb.ToString();
    }
}