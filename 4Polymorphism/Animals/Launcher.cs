using System;

namespace Animals
{
    public class Launcher
    {
        public static void Main()
        {
            Animal cat = new Cat("Pesho", "Whiskas2");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());
        }
    }
}
