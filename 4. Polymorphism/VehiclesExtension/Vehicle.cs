using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double tankCapacity;

    protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.TankCapacity = tankCapacity;
    }

    protected double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }

    protected double FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        set { this.fuelConsumptionPerKm = value; }
    }

    protected double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += fuel;
    }

    // general method for checking if the distance is doable
    public string TryTravel(double distance)
    {
        if (this.FuelConsumptionPerKm * distance <= this.FuelQuantity)
        {
            this.FuelQuantity -= this.FuelConsumptionPerKm * distance;
            return $"{GetType().Name} travelled {distance} km";
        }

        return $"{GetType().Name} needs refueling";
    }

    // overload required in case additional logic is needed when the AC is off
    public virtual string TryTravel(double distance, bool isAcOn)
    {
        return this.TryTravel(distance);
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
