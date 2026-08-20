using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.ISP
{
    // ISP is valid here because IShape2D only contains the Area() method, which is relevant to all 2D shapes. Any class that implements IShape2D must provide an implementation for the Area() method, ensuring that clients depending on IShape2D are not forced to implement methods they don't need.
    internal interface IShape2D
    {
        public double Area();
    }
}
