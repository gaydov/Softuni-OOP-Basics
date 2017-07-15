using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
        : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public int GoldTime { get; set; }

    public override void AddParticipant(int carId, Car car)
    {
        if (this.Participants.Count == 0)
        {
            base.AddParticipant(carId, car);
        }
    }

    public override int GetPointsOfCar(int carId)
    {
        Car currentCar = this.Participants[carId];

        return this.Length * currentCar.HorsePower / 100 * currentCar.Acceleration;
    }

    public override string StartRace()
    {
        KeyValuePair<int, Car> participant = this.Participants.ElementAt(0); // getting the only one participant

        int timePerformance = this.GetPointsOfCar(participant.Key);

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{participant.Value.Brand} {participant.Value.Model} - {timePerformance} s.");

        if (timePerformance <= this.GoldTime)
        {
            sb.AppendLine($"Gold Time, ${this.PrizePool}.");
        }
        else if (timePerformance <= this.GoldTime + 15)
        {
            sb.AppendLine($"Silver Time, ${this.PrizePool * 50 / 100}.");
        }
        else if (timePerformance > this.GoldTime + 15)
        {
            sb.AppendLine($"Bronze Time, ${this.PrizePool * 30 / 100}.");
        }

        return sb.ToString().Trim();
    }
}
