using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Composition
{
    internal class Wheel
    {
        public Wheel() { }

        public void Rotate()
        {
            Console.WriteLine("Wheel is rotating.");
        }
    }
}
