using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    public CarManager()
    {
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
        this.ClosedRacesIds = new List<int>();
    }

    private Dictionary<int, Car> Cars { get; set; }

    private Dictionary<int, Race> Races { get; set; }

    private Garage Garage { get; set; }

    private List<int> ClosedRacesIds { get; set; }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance":
                this.Cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
                break;

            case "Show":
                this.Cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
                break;
        }
    }

    public string Check(int id)
    {
        return this.Cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.Races.Add(id, new CasualRace(length, route, prizePool));
                break;

            case "Drag":
                this.Races.Add(id, new DragRace(length, route, prizePool));
                break;

            case "Drift":
                this.Races.Add(id, new DriftRace(length, route, prizePool));
                break;
        }
    }

    public void Open(int id, string type, int length, string route, int prizePool, int specialParam)
    {
        switch (type)
        {
            case "TimeLimit":
                this.Races.Add(id, new TimeLimitRace(length, route, prizePool, specialParam));
                break;

            case "Circuit":
                this.Races.Add(id, new CircuitRace(length, route, prizePool, specialParam));
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!Garage.ParkedCars.Contains(this.Cars[carId]))
        {
            if (!this.ClosedRacesIds.Contains(raceId))
            {
                this.Races[raceId].AddParticipant(carId, this.Cars[carId]);
            }
        }
    }

    public string Start(int id)
    {
        if (this.Races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        this.ClosedRacesIds.Add(id);
        return this.Races[id].StartRace();
    }

    public void Park(int id)
    {
        foreach (KeyValuePair<int, Race> race in this.Races.Where(r => !this.ClosedRacesIds.Contains(r.Key)))
        {
            if (race.Value.Participants.ContainsKey(id))
            {
                return;
            }
        }

        this.Garage.ParkedCars.Add(this.Cars[id]);
    }

    public void Unpark(int id)
    {
        this.Garage.ParkedCars.Remove(this.Cars[id]);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var parkedCar in this.Garage.ParkedCars)
        {
            parkedCar.Tune(tuneIndex, addOn);
        }
    }
}
