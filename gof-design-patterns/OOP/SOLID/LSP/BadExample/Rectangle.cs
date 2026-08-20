using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.LSP.BadExample
{
    internal class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public Rectangle() { }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
