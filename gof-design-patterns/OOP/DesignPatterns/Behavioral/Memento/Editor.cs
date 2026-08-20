using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.Memento
{
    internal class Editor
    {
        // Originator class
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }

        public void RestoreState(EditorState state)
        {
            Title = state.GetTitle();
            Content = state.GetContent();
        }
    }
}
