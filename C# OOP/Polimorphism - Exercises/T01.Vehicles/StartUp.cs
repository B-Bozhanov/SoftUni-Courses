namespace T01.Vehicles
{
    using global::Vehicles;
    using global::Vehicles.Core;
    using global::Vehicles.Core.Interfaces;
    using global::Vehicles.Models;
    using global::Vehicles.Models.Interfaces;
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {




            IEngine engine = new Engine();
            engine.Run();

        }
    }
}
