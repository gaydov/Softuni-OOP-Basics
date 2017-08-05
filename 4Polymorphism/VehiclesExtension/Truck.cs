public class Truck : Vehicle
{
    private const double ACFuelIncrease = 1.6;
    private const double PercentAfterFuelLoss = 0.95;

    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
        this.FuelConsumptionPerKm += ACFuelIncrease;
    }

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * PercentAfterFuelLoss);
    }
}
