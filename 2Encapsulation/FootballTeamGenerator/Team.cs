using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private Dictionary<string, Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.Players = new Dictionary<string, Player>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty");
            }

            this.name = value;
        }
    }

    public int Rating => this.CalcTeamRating();

    private Dictionary<string, Player> Players
    {
        get { return this.players; }
        set { this.players = value; }
    }

    public void RemovePlayer(string playerName)
    {
        if (!this.players.ContainsKey(playerName))
        {
            throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
        }

        this.players.Remove(playerName);
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player.Name, player);
    }

    public override string ToString()
    {
        return $"{this.name} - {this.Rating}";
    }

    private int CalcTeamRating()
    {
        if (this.players.Count > 0)
        {
            int result = (int)Math.Round(this.Players.Values.Average(p => p.Stats));
            return result;
        }

        return 0;
    }
}