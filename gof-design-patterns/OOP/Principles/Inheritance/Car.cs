using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Inheritance
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(String brand, String model, int year, int numberOfDoors)
            : base(brand, model, year)
        {
            this.NumberOfDoors = numberOfDoors;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Brand} {Model} ({Year}), Doors: {NumberOfDoors}";
        }

        // Polymorphic methods that define the behavior of starting and stopping the car.
        public override void Start()
        {
            Console.WriteLine("Car is starting with a roar!");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping with a screech!");
        }
    }
}
