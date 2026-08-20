using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.ISP
{
    internal class Circle : IShape2D
    {
        // ISP is valid here because Circle only implements the Area() method from IShape2D, and does not implement the Volume() method from IShape3D. This way, clients that only need 2D shapes can depend on IShape2D, while clients that need 3D shapes can depend on IShape3D without being forced to implement methods they don't need.
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
