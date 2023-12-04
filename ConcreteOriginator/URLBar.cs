using PatronMemento.Caretaker;
using PatronMemento.ConcreteMemento;
using PatronMemento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMemento.ConcreteOriginator
{
    public class URLBar : IOriginator
    {
        private string _url;
        private HistoryManager _historyManager;
        public URLBar (HistoryManager historyManager, string url)
        {
            _url= url;
            _historyManager = historyManager;
        }
        public void Save()
        {
            IMemento currentURL = new URLSnapshot(this, _url);
            _historyManager.SaveURL(currentURL);
        }
        public void SetState(string url)
        {
            _url = url;

        }
        public void NavigateTo(string endpoint)
        {
            Save();
            _url += $"{endpoint}/";
        }
        public string GetURL() => _url;

    }
}
