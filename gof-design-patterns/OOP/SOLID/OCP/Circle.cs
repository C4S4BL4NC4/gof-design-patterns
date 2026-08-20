using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.OCP
{
    internal class Circle : Shape
    {
        // SRP + OCP: The Circle class adheres to the Single Responsibility Principle (SRP) by focusing solely on circle-specific behavior, and it adheres to the Open/Closed Principle (OCP) by allowing new shapes to be added without modifying existing code.
        private double _radius;

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
