public class FoodFactory
{
    public static Food GenerateFood(string[] foodInfo)
    {
        string type = foodInfo[0].ToLower();
        int quantity = int.Parse(foodInfo[1]);

        switch (type)
        {
            case "meat":
                return new Meat(quantity);

            case "vegetable":
                return new Vegetable(quantity);

            default:
                return null;
        }
    }
}
