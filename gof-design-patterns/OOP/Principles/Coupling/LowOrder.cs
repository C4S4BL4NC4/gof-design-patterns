using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    internal class LowOrder : INotificationService
    {
        public LowOrder() { }

        public void PlaceOrder()
        {
            // This Order class is dependant on the INotificationService interface, which means that if we want to change the way we send notifications, we can simply implement a new class that adheres to the INotificationService interface. This is an example of low coupling.
            SendNotification("Order placed successfully with low coupling class.");
        }

        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending notification with message: {message}");
        }
    }
}
