using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    internal class HighOrder
    {
        public HighOrder() { }

        public void PlaceOrder()
        {
            // This Order class is dependant on the TightCouplingEmailSender class, which means that if we want to change the way we send emails, we would have to modify this class as well. This is an example of tight coupling.
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Order placed successfully with tight coupling class.");
        }
    }
}
