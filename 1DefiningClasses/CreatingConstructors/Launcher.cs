using System;
using System.Reflection;

namespace CreatingConstructors
{
    public class Launcher
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.Name, basePerson.Age);
            Console.WriteLine("{0} {1}", personWithAge.Name, personWithAge.Age);
            Console.WriteLine("{0} {1}", personWithAgeAndName.Name, personWithAgeAndName.Age);
        }
    }

    public class Person
    {
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}