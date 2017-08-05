using System;

namespace Vehicles
{
    public class Launcher
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int commandsCount = int.Parse(Console.ReadLine());

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            for (int i = 0; i < commandsCount; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[1].Equals("Car"))
                {
                    DriveOrRefuel(car, cmdArgs[0], double.Parse(cmdArgs[2]));
                }
                else if (cmdArgs[1].Equals("Truck"))
                {
                    DriveOrRefuel(truck, cmdArgs[0], double.Parse(cmdArgs[2]));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void DriveOrRefuel(Vehicle vehicle, string command, double parameter)
        {
            if (command.Equals("Drive"))
            {
                string result = vehicle.TryTravel(parameter);
                Console.WriteLine(result);
            }
            else
            {
                vehicle.Refuel(parameter);
            }
        }
    }
}
