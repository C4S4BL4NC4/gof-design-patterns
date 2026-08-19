using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Inheritance
{
    // Abstract class representing a vehicle which is just a concept and cannot be instantiated directly. It serves as a base class for specific types of vehicles like Car and Bike.
    internal abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        protected Vehicle(string brand, string model, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
        }

        // Polymorphic methods that must be implemented by derived classes. These methods define the behavior of starting and stopping the vehicle, but the specific implementation will vary depending on the type of vehicle.
        public abstract void Start();

        public abstract void Stop();

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Brand} {Model} ({Year})";
        }
    }
}
