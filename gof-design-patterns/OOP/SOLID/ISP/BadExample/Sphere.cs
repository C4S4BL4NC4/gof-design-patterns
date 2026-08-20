using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.ISP.BadExample
{
    internal class Sphere : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Radius * Radius * Radius;
        }
    }
}
