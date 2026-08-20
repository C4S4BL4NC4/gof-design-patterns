using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.LSP.BadExample
{
    internal class Square : Rectangle
    {
        public override double Width
        {
            get => base.Width;
            set => base.Width = value;
        }
        public override double Height
        {
            get => base.Height;
            set => base.Height = value;
        }
    }
}
