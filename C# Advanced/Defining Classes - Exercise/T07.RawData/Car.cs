
namespace RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
            double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, 
            int tire3Age, double tire4Pressure, int tire4Age)
        {
            var engine = new Engine(engineSpeed, enginePower);
            var cargo = new Cargo(cargoWeight, cargoType);
            var tires = new Tires[]                                
            {
                new Tires(tire1Pressure, tire1Age),
                new Tires(tire2Pressure, tire3Age),
                new Tires(tire3Pressure, tire3Age),
                new Tires(tire4Pressure, tire4Age)
            };

            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
    }
}
