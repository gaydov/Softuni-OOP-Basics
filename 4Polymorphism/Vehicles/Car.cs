public class Car : Vehicle
{
    private const double ACFuelIncrease = 0.9;

    public Car(double fuelQuantity, double fuelConsumptionPerKm)
        : base(fuelQuantity, fuelConsumptionPerKm)
    {
        this.FuelConsumptionPerKm += ACFuelIncrease;
    }
}
