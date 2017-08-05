using System;
using System.Linq;
using System.Reflection;

namespace ClassBoxDataValidation
{
    public class Launcher
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                double inputLength = double.Parse(Console.ReadLine());
                double inputWidth = double.Parse(Console.ReadLine());
                double inputHeight = double.Parse(Console.ReadLine());

                Box box = new Box(inputLength, inputWidth, inputHeight);
                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.GetVolume():F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
