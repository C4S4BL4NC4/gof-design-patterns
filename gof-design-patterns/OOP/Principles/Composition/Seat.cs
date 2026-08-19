using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Composition
{
    internal class Seat
    {
        public Seat() { }

        public void Sit()
        {
            Console.WriteLine("Sitting on the seat.");
        }
    }
}
