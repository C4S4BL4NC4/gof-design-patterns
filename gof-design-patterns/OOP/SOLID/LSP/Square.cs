using System;
using System.Collections.Generic;
using System.Text;
using gof_design_patterns.OOP.SOLID.LSP.BadExample;

namespace gof_design_patterns.OOP.SOLID.LSP
{
    // Good Example of Liskov Substitution Principle (LSP)
    internal class Square : Shape
    {
        public double SideLength { get; set; }

        public Square() { }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
