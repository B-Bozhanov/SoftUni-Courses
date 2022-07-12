namespace T01.Vehicles
{
    using global::Vehicles.Models;
    using global::Vehicles.Models.Interfaces;
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                string vehicle = command[1];

                if (action == "Drive")
                {
                    double distance = double.Parse(command[2]);
                    if (vehicle == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (vehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else if (action == "Refuel")
                {
                    var fuel = double.Parse(command[2]);
                    if (vehicle == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
