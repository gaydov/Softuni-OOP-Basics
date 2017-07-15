using System.Collections.Generic;

public class Garage
{
    public Garage()
    {
        this.ParkedCars = new List<Car>();
    }

    public List<Car> ParkedCars { get; set; }
}
