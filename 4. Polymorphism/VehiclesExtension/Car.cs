
using System;

public class Car : Vehicle
{
    private const double ACFuelIncrease = 0.9;

    public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
        this.FuelConsumptionPerKm += ACFuelIncrease;
    }

    public override void Refuel(double fuel)
    {
        if (this.FuelQuantity + fuel > this.TankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }

        base.Refuel(fuel);
    }
}
