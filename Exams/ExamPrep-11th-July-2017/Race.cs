using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
    }

    public Dictionary<int, Car> Participants { get; set; }

    public int PrizePool { get; set; }

    public string Route { get; set; }

    public int Length { get; set; }

    public virtual void AddParticipant(int carId, Car car)
    {
        this.Participants.Add(carId, car);
    }

    public abstract int GetPointsOfCar(int carId);

    public virtual string StartRace()
    {
        Dictionary<int, int> raceResults = new Dictionary<int, int>();

        foreach (KeyValuePair<int, Car> racer in this.Participants)
        {
            int currentRacerPoints = this.GetPointsOfCar(racer.Key);
            raceResults.Add(racer.Key, currentRacerPoints);
        }

        // getting the winners to dictionary which key is a car's ID and the value is the points earned
        Dictionary<int, int> winners = raceResults.OrderByDescending(r => r.Value).Take(3).ToDictionary(m => m.Key, n => n.Value);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        int position = 1;

        foreach (KeyValuePair<int, int> winner in winners)
        {
            Car currentCar = Participants[winner.Key];

            sb.AppendLine(
                $"{position}. {currentCar.Brand} {currentCar.Model} {winner.Value}PP - ${GeneratePrizes()[position - 1]}");

            position++;
        }

        return sb.ToString().Trim();
    }

    public virtual List<int> GeneratePrizes()
    {
        List<int> prizes = new List<int>();

        prizes.Add(this.PrizePool * 50 / 100);
        prizes.Add(this.PrizePool * 30 / 100);
        prizes.Add(this.PrizePool * 20 / 100);

        return prizes;
    }
}
