using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Launcher
    {
        public static void Main()
        {
            string[] inputPeople = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            foreach (string person in inputPeople)
            {
                string[] args = person.Split('=');

                try
                {
                    Person currentPerson = new Person(args[0], decimal.Parse(args[1]));
                    people.Add(currentPerson);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            List<Product> products = new List<Product>();

            string[] inputProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string product in inputProducts)
            {
                string[] args = product.Split('=');

                try
                {
                    Product currentProduct = new Product(args[0], decimal.Parse(args[1]));
                    products.Add(currentProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                string[] args = input.Split();
                string personName = args[0];
                string productName = args[1];

                Person currentPerson = people.FirstOrDefault(person => person.Name.Equals(personName));
                Product currentProduct = products.FirstOrDefault(product => product.Name.Equals(productName));

                if (currentPerson.Money >= currentProduct.Cost)
                {
                    currentPerson.Money -= currentProduct.Cost;
                    currentPerson.Bag.Add(currentProduct);
                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }

                input = Console.ReadLine();
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
