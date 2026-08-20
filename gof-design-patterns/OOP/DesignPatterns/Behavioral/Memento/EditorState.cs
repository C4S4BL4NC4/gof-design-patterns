using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.Memento
{
    internal class EditorState
    {
        // Memento class
        private readonly string _title;
        private readonly string _content;

        // State metadata

        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetName()
        {
            return $"{_stateCreatedAt.ToString("yyyy-MM-dd HH:mm:ss")} - {_title}";
        }

        public DateTime GetStateCreatedAt()
        {
            return _stateCreatedAt;
        }
    }
}
