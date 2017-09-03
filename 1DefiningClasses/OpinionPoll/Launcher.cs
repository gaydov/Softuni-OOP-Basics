using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                Person currentPerson = new Person();
                string[] args = Console.ReadLine().Split();
                string name = args[0];
                int age = int.Parse(args[1]);
                currentPerson.Name = name;
                currentPerson.Age = age;
                people.Add(currentPerson);
            }

            foreach (Person person in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
