using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.State
{
    internal class Document
    {
        public State State { get; set; }
        public UserRoles UserRole { get; set; }

        public Document(UserRoles userRole)
        {
            State = new DraftState(this);
            UserRole = userRole;
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}
