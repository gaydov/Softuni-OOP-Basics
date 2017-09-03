using System;

namespace VehiclesExtension
{
    public class Launcher
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int commandsCount = int.Parse(Console.ReadLine());

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            for (int i = 0; i < commandsCount; i++)
            {
                try
                {
                    string[] cmdArgs = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cmdArgs[1].Equals("Car"))
                    {
                        DriveOrRefuel(car, cmdArgs[0], double.Parse(cmdArgs[2]));
                    }
                    else if (cmdArgs[1].Equals("Truck"))
                    {
                        DriveOrRefuel(truck, cmdArgs[0], double.Parse(cmdArgs[2]));
                    }
                    else if (cmdArgs[1].Equals("Bus"))
                    {
                        DriveOrRefuel(bus, cmdArgs[0], double.Parse(cmdArgs[2]));
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void DriveOrRefuel(Vehicle vehicle, string command, double parameter)
        {
            if (command.Equals("Drive"))
            {
                string result = vehicle.TryTravel(parameter);
                Console.WriteLine(result);
            }
            else if (command.Equals("Refuel"))
            {
                vehicle.Refuel(parameter);
            }
            else if (command.Equals("DriveEmpty"))
            {
                string result = vehicle.TryTravel(parameter, false);
                Console.WriteLine(result);
            }
        }
    }
}
