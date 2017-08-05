using System;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;
    private int stats;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
        this.Stats = this.CaclPlayerStats();
    }

    public string Name
    {
        get { return this.name; }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty");
            }

            this.name = value;
        }
    }

    private int Endurance
    {
        get { return this.endurance; }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
            }

            this.endurance = value;
        }
    }

    private int Sprint
    {
        get { return this.sprint; }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
            }

            this.sprint = value;
        }
    }

    private int Dribble
    {
        get { return this.dribble; }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
            }

            this.dribble = value;
        }
    }

    private int Passing
    {
        get { return this.passing; }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
            }

            this.passing = value;
        }
    }

    private int Shooting
    {
        get { return this.shooting; }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
            }

            this.shooting = value;
        }
    }

    public int Stats
    {
        get { return this.stats; }
        private set { this.stats = value; }
    }

    private int CaclPlayerStats()
    {
        int result = (int)Math.Round((this.Endurance + this.Dribble + this.Passing + this.Shooting + this.Sprint) / 5.0);
        return result;
    }
}

