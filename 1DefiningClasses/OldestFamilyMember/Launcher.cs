using System;
using System.Reflection;

namespace OldestFamilyMember
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                Person currentMember = new Person();
                currentMember.Name = args[0];
                currentMember.Age = int.Parse(args[1]);

                family.AddMember(currentMember);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }
        }
    }
}
