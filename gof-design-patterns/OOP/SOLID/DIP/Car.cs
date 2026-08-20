using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.DIP
{
    internal class Car
    {
        // Car class depends on the IEngine interface, which is an abstraction. This adheres to the Dependency Inversion Principle (DIP).
        // The concrete implementation of IEngine (e.g., Engine class) can be injected into the Car class, allowing for flexibility and easier testing.
        // For example, we can inject a  gas engine, electric engine, or any other type of engine that implements the IEngine interface without modifying the Car class.
        public IEngine engine { get; set; }

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
        }

        public void StopCar()
        {
            engine.Stop();
        }
    }
}
