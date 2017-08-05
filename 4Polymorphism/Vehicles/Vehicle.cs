
public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;

    protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    protected virtual double FuelConsumptionPerKm
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
        this.FuelQuantity += fuel;
    }

    public string TryTravel(double distance)
    {
        if (this.FuelConsumptionPerKm * distance <= this.FuelQuantity)
        {
            this.FuelQuantity -= this.FuelConsumptionPerKm * distance;
            return $"{GetType().Name} travelled {distance} km";
        }

        return $"{GetType().Name} needs refueling";
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
