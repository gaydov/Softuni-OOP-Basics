using System;

namespace DateModifierPgm
{
    public class Launcher
    {
        public static void Main()
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            DateModifier modifier = new DateModifier();
            modifier.CalculateDifference(startDate, endDate);
            Console.WriteLine(modifier.Difference);
        }
    }
}
