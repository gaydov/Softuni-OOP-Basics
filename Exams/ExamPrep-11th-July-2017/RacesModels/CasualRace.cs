public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool)
    : base(length, route, prizePool)
    {
    }

    public override int GetPointsOfCar(int carId)
    {
        Car currentCar = this.Participants[carId];

        return (currentCar.HorsePower / currentCar.Acceleration) + (currentCar.Suspension + currentCar.Durability);
    }
}
