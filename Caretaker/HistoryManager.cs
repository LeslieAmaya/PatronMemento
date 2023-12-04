using PatronMemento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMemento.Caretaker
{
    public class HistoryManager
    {
        private Stack<IMemento> _history;
        public HistoryManager()
        {
            _history = new Stack<IMemento>();
        }
        public void SaveURL (IMemento urlSnapshot)
        {
            _history.Push(urlSnapshot);
        }
        public void Undo()
        {
            if (_history.Count == 0) return;
            IMemento lastURL = _history.Pop();
            lastURL.Restore();
        }
    }
}
