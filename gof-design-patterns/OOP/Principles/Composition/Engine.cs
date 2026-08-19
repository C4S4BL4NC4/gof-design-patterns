using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Composition
{
    internal class Engine
    {
        public Engine() { }

        public void Start()
        {
            Console.WriteLine("Engine starts running.");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stops running.");
        }
    }
}
