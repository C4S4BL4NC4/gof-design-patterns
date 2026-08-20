using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.ISP
{
    // ISP is valid here because IShape3D extends IShape2D, and any class that implements IShape3D must also implement the Area() method from IShape2D. This way, clients that only need 2D shapes can depend on IShape2D, while clients that need 3D shapes can depend on IShape3D without being forced to implement methods they don't need.
    internal interface IShape3D : IShape2D
    {
        public double Volume();
    }
}
