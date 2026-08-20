using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.OCP.BadExample
{
    // This class violates the Open/Closed Principle (OCP) because it requires modification whenever a new shape type is added. Instead, we should use polymorphism to allow for extension without modifying existing code.
    internal class Shape
    {
        public ShapeType Type { get; set; }
        public double Radius { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return Math.PI * Radius * Radius;
                case ShapeType.Square:
                    return Length * Width;
                case ShapeType.Triangle:
                    return 0.5 * Length * Width;
                default:
                    throw new NotImplementedException("Unsupported shape type");
            }
        }
    }
}
