using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
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
                string carModel = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tyre1PS = double.Parse(input[5]);
                int tyre1Age = int.Parse(input[6]);
                double tyre2PS = double.Parse(input[7]);
                int tyre2Age = int.Parse(input[8]);
                double tyre3PS = double.Parse(input[9]);
                int tyre3Age = int.Parse(input[10]);
                double tyre4PS = double.Parse(input[11]);
                int tyre4Age = int.Parse(input[12]);

                Car currentCar = new Car(carModel, engineSpeed, enginePower, cargoWeight, cargoType, tyre1PS, tyre1Age,
                    tyre2PS, tyre2Age, tyre3PS, tyre3Age, tyre4PS, tyre4Age);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();
            if (command.Equals("fragile"))
            {
                foreach (Car car in cars.Where(c => c.Cargo.CargoType.Equals("fragile")).Where(c => c.Tyres.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command.Equals("flamable"))
            {
                foreach (Car car in cars.Where(c => c.Cargo.CargoType.Equals("flamable")).Where(c => c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
