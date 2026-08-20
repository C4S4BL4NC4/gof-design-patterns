using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.SRP
{
    internal class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            // Logic to send an email
            Console.WriteLine($"Email sent to {email} with message: {message}");
        }
    }
}
