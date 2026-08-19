using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Abstraction
{
    internal class BadEmailService
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SMTP server...");
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

        public void Send()
        {
            Console.WriteLine("Sending email...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from SMTP server...");
        }
    }
}
