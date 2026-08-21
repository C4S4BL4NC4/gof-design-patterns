using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.State.BadExample
{
    internal class Document
    {
        // Context class
        public DocumentStates State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {
            if (State == DocumentStates.Draft)
            {
                State = DocumentStates.Moderation;
                Console.WriteLine("Document published for moderation.");
            }
            else if (State == DocumentStates.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStates.Published;
                    Console.WriteLine("Document published.");
                }
                else
                {
                    Console.WriteLine("Only admins can publish documents.");
                }
            }
            else if (State == DocumentStates.Published)
            {
                Console.WriteLine("Document is already published.");
            }
        }
    }
}
