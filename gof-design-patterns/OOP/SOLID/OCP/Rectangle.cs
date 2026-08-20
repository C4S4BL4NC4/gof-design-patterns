using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.OCP
{
    internal class Rectangle : Shape
    {
        // SRP + OCP: The Rectangle class adheres to the Single Responsibility Principle (SRP) by focusing solely on rectangle-specific behavior, and it adheres to the Open/Closed Principle (OCP) by allowing new shapes to be added without modifying existing code.
        private double _length;
        private double _width;

        public override double GetArea()
        {
            return _length * _width;
        }
    }
}
