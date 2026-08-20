using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.DIP
{
    internal class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Electric engine stopped.");
        }
    }
}
