using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
