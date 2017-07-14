public class Truck : Vehicle
{
    private const double ACFuelIncrease = 1.6;
    private const double PercentAfterFuelLoss = 0.95;

    public Truck(double fuelQuantity, double fuelConsumptionPerKm)
        : base(fuelQuantity, fuelConsumptionPerKm)
    {
        this.FuelConsumptionPerKm += ACFuelIncrease;
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel * PercentAfterFuelLoss;
    }
}
