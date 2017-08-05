using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class Launcher
    {
        public static void Main()
        {
            int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rectanglesCount = args[0];
            int checksCount = args[1];
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                Rectangle currentRectangle = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4]));
                rectangles.Add(currentRectangle);
            }

            for (int i = 0; i < checksCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                Rectangle r1 = rectangles.FirstOrDefault(r => r.ID.Equals(input[0]));
                Rectangle r2 = rectangles.FirstOrDefault(r => r.ID.Equals(input[1]));
                Console.WriteLine(r1.DoIntersectWith(r2).ToString().ToLower());
            }
        }
    }
}
