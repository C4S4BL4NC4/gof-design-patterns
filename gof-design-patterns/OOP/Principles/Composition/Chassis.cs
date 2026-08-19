using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Composition
{
    internal class Chassis
    {
        public Chassis() { }

        public void Support()
        {
            Console.WriteLine("Chassis is supporting the car.");
        }
    }
}
