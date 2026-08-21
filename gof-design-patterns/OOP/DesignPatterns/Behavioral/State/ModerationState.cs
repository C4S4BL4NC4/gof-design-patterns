using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.State
{
    internal class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.UserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
                Console.WriteLine("Document published successfully.");
            }
            else
            {
                Console.WriteLine("Only Admin can publish the document.");
            }
        }
    }
}
