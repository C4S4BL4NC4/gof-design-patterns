using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.DesignPatterns.Behavioral.Memento
{
    internal class History
    {
        // Caretaker class
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count == 0)
            {
                Console.WriteLine("No states to restore.");
                return;
            }
            var lastState = _states.Last();
            _states.Remove(lastState);
            _editor.RestoreState(lastState);
        }

        public void ShowHistory()
        {
            Console.WriteLine("History of states:");
            foreach (var state in _states)
            {
                Console.WriteLine(state.GetName());
            }
        }
    }
}
