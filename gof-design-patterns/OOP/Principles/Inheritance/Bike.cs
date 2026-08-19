using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Inheritance
{
    internal class Bike : Vehicle
    {
        public int NumberOfWheels { get; set; }

        public Bike(String brand, String model, int year, int numberOfWheels)
            : base(brand, model, year)
        {
            this.NumberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Brand} {Model} ({Year}), Wheels: {NumberOfWheels}";
        }

        // Polymorphic methods that define the behavior of starting and stopping the bike.
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a bell!");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike is stopping with a brake!");
        }
    }
}
