using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.State
{
    internal class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            Console.WriteLine("Document is already published.");
        }
    }
}
