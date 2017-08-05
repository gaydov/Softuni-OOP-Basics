
using System.Collections.Generic;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tyre> tyres;

    public Car(string model, int engSpeed, int engPower, int cargoWeight, string cargoType,
        double tyre1PS, int tyre1Age, double tyre2PS, int tyre2Age, double tyre3PS, int tyre3Age, double tyre4PS, int tyre4Age)
    {
        this.model = model;
        this.engine = new Engine(engSpeed, engPower);
        this.cargo = new Cargo(cargoWeight, cargoType);
        this.tyres = new List<Tyre>();

        Tyre firstTyre = new Tyre(tyre1PS, tyre1Age);
        tyres.Add(firstTyre);
        Tyre secondTyre = new Tyre(tyre2PS, tyre2Age);
        tyres.Add(secondTyre);
        Tyre thirdTyre = new Tyre(tyre3PS, tyre3Age);
        tyres.Add(thirdTyre);
        Tyre fourthTyre = new Tyre(tyre4PS, tyre4Age);
        tyres.Add(fourthTyre);
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }

    public List<Tyre> Tyres
    {
        get { return this.tyres; }
        set { this.tyres = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }
}

