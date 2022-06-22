using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly List<Car> cars;


        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.cars = new List<Car>();
        }


        public string Type { get; }


        public int Capacity { get; private set; }


        public int Count { get => this.cars.Count; private set => value = this.cars.Count; }

        public void Add(Car car)
        {
            if (this.Capacity > 0)
            {
                this.cars.Add(car);
                this.Capacity--;
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Car car = this.cars.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            return this.cars.Remove(car);
        }
        public Car GetLatestCar()
        {
            if (this.cars.Count != 0)
            {
                var current = cars.Max(x => x.Year);
                return this.cars.FirstOrDefault(c => c.Year == current);
            }
            return null;
        }
        public Car GetCar(string manufacturer, string model)
        {
            return this.cars.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
        }
        public string GetStatistics()
        {
            var statistic = new StringBuilder();
            statistic.AppendLine($"The cars are parked in {this.Type}:");

            foreach (Car car in this.cars)
            {
                statistic.AppendLine(car.ToString());
            }

            return statistic.ToString().TrimEnd();
        }
    }
}
