using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    // Low-order coupling (also known as loose coupling) is a design principle that aims to reduce the dependencies between different components or modules in a software system. In low-order coupling, components are designed to be independent and interact with each other through well-defined interfaces, rather than being tightly coupled together. This makes the system more flexible, maintainable, and easier to test.
    internal class LowOrder : INotificationService
    {
        private readonly INotificationService _notificationService;

        public LowOrder(INotificationService notificationService)
        {
            this._notificationService = notificationService;
        }

        public void SendNotification(string message)
        {
            _notificationService.SendNotification(message);
        }
    }
}
