using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.OCP
{
    // This abstract class represents a shape and defines a method to calculate its area. It adheres to the Open/Closed Principle (OCP) by allowing new shapes to be added without modifying existing code.
    internal abstract class Shape
    {
        public abstract double GetArea();
    }
}
