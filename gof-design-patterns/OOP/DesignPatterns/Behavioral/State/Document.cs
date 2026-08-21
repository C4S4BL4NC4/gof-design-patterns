using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.State
{
    internal class Document
    {
        // The main idea is that we don't to modify the Document class when we add new states. We just need to create a new state class that implements the State interface and change the state of the document to the new state.
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
