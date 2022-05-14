
namespace T08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }


        public override string ToString()
        {
            var displacement = IsHaveElement(Engine.Displacement.ToString());
            var efficiency = IsHaveElement(Engine.Efficiency);
            var weight = IsHaveElement(Weight.ToString());
            var color = IsHaveElement(Color);

            var carInfo = $@"{Model}:
  {Engine.Model}:
    Power: {Engine.Power}
    Displacement: {displacement}
    Efficiency: {efficiency}
  Weight: {weight}
  Color: {color}";
            return carInfo;
        }

        private string IsHaveElement(string element)
        {
            if (element == null || element == "0")
            {
                return "n/a";
            }
            return element;
        }
    }
}
