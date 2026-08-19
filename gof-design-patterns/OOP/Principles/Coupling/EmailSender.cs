using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Coupling
{
    internal class EmailSender
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email with message: {message}");
        }
    }
}
