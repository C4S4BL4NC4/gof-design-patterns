using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.DIP.BadExample
{
    internal class Car
    {
        // Car class depends directly on the concrete Engine class, which is a low-level module. This violates the Dependency Inversion Principle (DIP).
        // To fix it and adhere to DIP, we should depend on an abstraction (e.g., an interface) instead of a concrete class.
        private Engine engine;

        public Car()
        {
            engine = new Engine();
        }

        public void StartCar()
        {
            engine.Start();
        }
    }
}
