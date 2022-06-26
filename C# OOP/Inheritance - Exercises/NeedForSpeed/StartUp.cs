namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RaceMotorcycle motor = new RaceMotorcycle(125, 20);
            SportCar car = new SportCar(350, 75);

            motor.Drive(2);
            car.Drive(5);
            System.Console.WriteLine(motor.Fuel);
            System.Console.WriteLine(motor.FuelConsumption);
            System.Console.WriteLine(car.Fuel);
            System.Console.WriteLine(car.FuelConsumption);
        }
    }
}
