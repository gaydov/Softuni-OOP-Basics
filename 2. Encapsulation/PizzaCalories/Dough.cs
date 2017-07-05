using System;
using System.Linq;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    private readonly string[] allowedTypes = { "white", "wholegrain" };
    private readonly string[] allowedTechniques = { "crispy", "chewy", "homemade" };
    private const double whiteModifier = 1.5;
    private const double wholeGrainModifier = 1.0;
    private const double crispyModifier = 0.9;
    private const double chewyModifier = 1.1;
    private const double homeMadeModifier = 1.0;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        set
        {
            if (!allowedTypes.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        set
        {
            if (!allowedTechniques.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakingTechnique = value;
        }
    }

    public double Weight
    {
        set
        {
            if (value < 0 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.weight = value;
        }
    }

    public double CalcDoughCalories()
    {
        double flourModifier = 0;

        switch (this.flourType.ToLower())
        {
            case "white":
                flourModifier = whiteModifier;
                break;

            case "wholegrain":
                flourModifier = wholeGrainModifier;
                break;
        }

        double bakingModifier = 0;

        switch (this.bakingTechnique.ToLower())
        {
            case "crispy":
                bakingModifier = crispyModifier;
                break;

            case "chewy":
                bakingModifier = chewyModifier;
                break;

            case "homemade":
                bakingModifier = homeMadeModifier;
                break;
        }

        return 2 * this.weight * flourModifier * bakingModifier;
    }
}

