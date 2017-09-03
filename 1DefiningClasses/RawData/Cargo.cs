public class Cargo
{
    private int cargoWeight = 0;
    private string cargoType = string.Empty;

    public Cargo(int weight, string type)
    {
        this.cargoWeight = weight;
        this.cargoType = type;
    }

    public int CargoWeight
    {
        get { return this.cargoWeight; }
        set { this.cargoWeight = value; }
    }

    public string CargoType
    {
        get { return this.cargoType; }
        set { this.cargoType = value; }
    }
}