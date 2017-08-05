public class AnimalFactory
{
    public static Animal GenerateAnimal(string[] animalInfo)
    {
        string type = animalInfo[0].ToLower();
        string name = animalInfo[1];
        double weight = double.Parse(animalInfo[2]);
        string region = animalInfo[3];

        switch (type)
        {
            case "mouse":
                return new Mouse(name, type, weight, region);

            case "zebra":
                return new Zebra(name, type, weight, region);

            case "cat":
                string breed = animalInfo[4];
                return new Cat(name, type, weight, region, breed);

            case "tiger":
                return new Tiger(name, type, weight, region);

            default:
                return null;
        }
    }
}
