using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.ISP
{
    internal class Sphere : IShape3D
    {
        // ISP is valid here because Sphere implements both the Area() method from IShape2D and the Volume() method from IShape3D. This way, clients that need 3D shapes can depend on IShape3D without being forced to implement methods they don't need, while clients that only need 2D shapes can depend on IShape2D without being forced to implement methods they don't need.
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Radius * Radius * Radius;
        }
    }
}
