using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace gof_design_patterns.OOP.Principles.Abstraction
{
    internal class BetterEmailService : BadEmailService
    {
        private readonly string _message;

        public BetterEmailService(string message)
        {
            _message = message;
        }

        // Abstraction: The SendEmail method provides a simplified interface for sending an email, hiding the underlying complexity of connecting, authenticating, sending, and disconnecting from the email service.
        public void SendEmail()
        {
            base.Connect();
            base.Authenticate();
            base.Send();
            base.Disconnect();

            Console.WriteLine($"Message sent: {_message}");
        }
    }
}
