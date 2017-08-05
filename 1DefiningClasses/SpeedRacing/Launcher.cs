using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car currentCar = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            while (!command.Equals("End"))
            {
                string[] args = command.Split();
                string model = args[1];
                int distance = int.Parse(args[2]);

                Car currentCar = cars.FirstOrDefault(c => c.Model.Equals(model));
                if (!currentCar.IsFuelEnough(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
