using System;
using System.Collections.Generic;

namespace Animals
{
    public class Launcher
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();

            while (!input.Equals("Beast!"))
            {
                string animalType = input;
                string[] animalArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = animalArgs[0];
                int age = int.Parse(animalArgs[1]);
                string gender = animalArgs[2];

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            animals.Add(new Dog(name, age, gender));
                            break;

                        case "Cat":
                            animals.Add(new Cat(name, age, gender));
                            break;

                        case "Frog":
                            animals.Add(new Frog(name, age, gender));
                            break;

                        case "Kitten":
                            animals.Add(new Kitten(name, age));
                            break;

                        case "Tomcat":
                            animals.Add(new Tomcat(name, age));
                            break;

                        default:
                            Console.WriteLine("Invalid input!");
                            break;

                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                input = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
