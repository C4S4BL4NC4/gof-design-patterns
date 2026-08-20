using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.ISP.BadExample
{
    internal class Circle : IShape
    {
        // Circle class violates the Interface Segregation Principle (ISP) because it implements the IShape interface, which includes a Volume() method that is not applicable to 2D shapes like circles. Sphere is a 3D shape and has a volume.
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Volume()
        {
            // This method is not applicable to a 2D circle, but is required by the IShape interface.
            throw new NotImplementedException("Circle does not have a volume.");
        }
    }
}
