using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    internal class SmsSender : INotificationService
    {
        public SmsSender() { }

        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification with message: {message}");
        }
    }
}
