using System;

namespace WildFarm
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] animalInfo = input.Split();
                Animal animal = AnimalFactory.GenerateAnimal(animalInfo);
               
                string[] foodInfo = Console.ReadLine().Split();
                Food food = FoodFactory.GenerateFood(foodInfo);
                
                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                Console.WriteLine(animal);

                input = Console.ReadLine();
            }
        }
    }
}
