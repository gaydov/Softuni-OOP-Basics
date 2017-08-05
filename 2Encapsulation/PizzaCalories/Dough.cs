using System;
using System.Linq;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    private readonly string[] allowedTypes = { "white", "wholegrain" };
    private readonly string[] allowedTechniques = { "crispy", "chewy", "homemade" };
    private const double WhiteModifier = 1.5;
    private const double WholeGrainModifier = 1.0;
    private const double CrispyModifier = 0.9;
    private const double ChewyModifier = 1.1;
    private const double HomeMadeModifier = 1.0;

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
                flourModifier = WhiteModifier;
                break;

            case "wholegrain":
                flourModifier = WholeGrainModifier;
                break;
        }

        double bakingModifier = 0;

        switch (this.bakingTechnique.ToLower())
        {
            case "crispy":
                bakingModifier = CrispyModifier;
                break;

            case "chewy":
                bakingModifier = ChewyModifier;
                break;

            case "homemade":
                bakingModifier = HomeMadeModifier;
                break;
        }

        return 2 * this.weight * flourModifier * bakingModifier;
    }
}

