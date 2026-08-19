using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    internal class BetterEmailSender : INotificationService
    {
        public BetterEmailSender() { }

        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending email notification with message: {message}");
        }
    }
}
