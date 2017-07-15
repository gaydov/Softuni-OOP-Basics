public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }

    public override int GetPointsOfCar(int carId)
    {
        Car currentCar = this.Participants[carId];

        return currentCar.HorsePower / currentCar.Acceleration;
    }
}
