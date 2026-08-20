using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.SRP
{
    internal class BadUser
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // This class violates the Single Responsibility Principle (SRP) because it has two responsibilities: user registration and sending a welcome email.
        // It has more than one reason to change, which makes it harder to maintain and test. If the email sending logic changes, it will affect the user registration logic as well.
        public void Register()
        {
            // Code to register the user logic...
            gof_design_patterns.OOP.SOLID.SRP.EmailSender emailSender =
                new gof_design_patterns.OOP.SOLID.SRP.EmailSender();
            emailSender.SendEmail(Email, "Welcome to our service!");
        }
    }
}
