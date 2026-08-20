using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.SOLID.SRP
// Business logic related to registering a user, logging, and other user-related operations can be implemented here.
{
    internal class UserService
    {
        public void RegisterUser(string name, string email)
        {
            // Logic to register a user
            gof_design_patterns.OOP.SOLID.SRP.EmailSender emailSender =
                new gof_design_patterns.OOP.SOLID.SRP.EmailSender();
            emailSender.SendEmail(email, "Welcome to our service!");
        }
    }
}
