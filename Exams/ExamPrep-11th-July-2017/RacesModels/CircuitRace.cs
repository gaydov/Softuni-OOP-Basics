using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : CasualRace
{
    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public int Laps { get; set; }

    public override string StartRace()
    {
        for (int i = 0; i < this.Laps; i++)
        {
            foreach (KeyValuePair<int, Car> racer in this.Participants)
            {
                racer.Value.Durability -= this.Length * this.Length;
            }
        }

        Dictionary<int, int> raceResults = new Dictionary<int, int>();

        foreach (KeyValuePair<int, Car> racer in this.Participants)
        {
            int pointsEarned = this.GetPointsOfCar(racer.Key);
            raceResults.Add(racer.Key, pointsEarned);
        }

        // getting the winners to dictionary which key is a car's ID and the value is the points earned
        Dictionary<int, int> winners = raceResults.OrderByDescending(r => r.Value).Take(4).ToDictionary(m => m.Key, n => n.Value);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length * this.Laps}");

        int position = 1;

        foreach (KeyValuePair<int, int> racer in winners)
        {
            Car currentCar = Participants[racer.Key];

            sb.AppendLine(
                $"{position}. {currentCar.Brand} {currentCar.Model} {racer.Value}PP - ${GeneratePrizes()[position - 1]}");

            position++;
        }

        return sb.ToString().Trim();
    }

    public override List<int> GeneratePrizes()
    {
        List<int> prizes = new List<int>();

        prizes.Add(this.PrizePool * 40 / 100);
        prizes.Add(this.PrizePool * 30 / 100);
        prizes.Add(this.PrizePool * 20 / 100);
        prizes.Add(this.PrizePool * 10 / 100);

        return prizes;
    }
}
