using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Composition
{
    internal class Car
    {
        private Engine engine;
        private Chassis chassis;
        private Wheel wheel;
        private Seat seat;

        public Car()
        {
            engine = new Engine();
            chassis = new Chassis();
            wheel = new Wheel();
            seat = new Seat();
        }

        public void StartCar()
        {
            engine.Start();
            chassis.Support();
            seat.Sit();
            wheel.Rotate();
            Drive();
            engine.Stop();
        }

        private void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }
}
