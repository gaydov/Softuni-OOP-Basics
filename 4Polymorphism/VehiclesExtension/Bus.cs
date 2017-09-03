using System;

public class Bus : Vehicle
{
    private const double ACFuelIncrease = 1.4;

    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
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

    public override string TryTravel(double distance, bool isAcOn)
    {
        // the AC is on by default so the distance is passed directly to the base class' method with only 1 argument
        if (isAcOn)
        {
            return base.TryTravel(distance);
        }

        // if the AC is off the fuel consumption is decreased and then the method with only 1 argument is called
        this.FuelConsumptionPerKm -= ACFuelIncrease;
        return base.TryTravel(distance);
    }
}