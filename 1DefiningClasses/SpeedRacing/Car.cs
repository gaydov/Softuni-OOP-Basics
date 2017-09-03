public class Car
{
    private string model = string.Empty;
    private double fuelAmount = 0;
    private double fuelPerKm = 0;
    private double distanceTraveled = 0;

    public Car(string model, double fuelAmount, double fuelPerKm)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelPerKm = fuelPerKm;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public bool IsFuelEnough(int distance)
    {
        if (this.fuelPerKm * distance <= this.fuelAmount)
        {
            this.fuelAmount -= this.fuelPerKm * distance;
            this.distanceTraveled += distance;
            return true;
        }

        return false;
    }
}