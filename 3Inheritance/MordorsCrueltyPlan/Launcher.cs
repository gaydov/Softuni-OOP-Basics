using System;
using System.Collections.Generic;
using System.Linq;

namespace MordorsCrueltyPlan
{
    public class Launcher
    {
        public static void Main()
        {
            string[] foodArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Food> foods = new List<Food>();

            foreach (string food in foodArgs)
            {
                Food currentFood = FoodFactory.GenerateFood(food);
                foods.Add(currentFood);
            }

            Mood mood = MoodFactory.GenerateMood(foods);

            Console.WriteLine(foods.Sum(f => f.PointsOfHappines));
            Console.WriteLine(mood);
        }
    }
}
