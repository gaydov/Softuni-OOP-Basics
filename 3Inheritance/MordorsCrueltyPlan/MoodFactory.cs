using System.Collections.Generic;
using System.Linq;

public class MoodFactory
{
    public static Mood GenerateMood(List<Food> foods)
    {
        int summedIndexOfHappines = foods.Sum(f => f.PointsOfHappines);

        if (summedIndexOfHappines < -5)
        {
            return new Angry();
        }
        else if (-5 <= summedIndexOfHappines && summedIndexOfHappines <= 0)
        {
            return new Sad();
        }
        else if (1 <= summedIndexOfHappines && summedIndexOfHappines <= 15)
        {
            return new Happy();
        }
        else
        {
            return new JavaScript();
        }
    }
}

