using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.State
{
    internal class DraftState : State
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            _document.State = new ModerationState(_document);
            Console.WriteLine("Document is now in moderation.");
        }
    }
}
