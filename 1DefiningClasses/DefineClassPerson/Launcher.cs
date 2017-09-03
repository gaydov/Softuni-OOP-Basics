using System;
using System.Reflection;

namespace DefineClassPerson
{
    public class Launcher
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }

    public class Person
    {
        public string name = string.Empty;
        public int age = 0;
    }
}