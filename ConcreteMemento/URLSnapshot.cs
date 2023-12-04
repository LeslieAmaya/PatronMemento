using PatronMemento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMemento.ConcreteMemento
{
    public class URLSnapshot : IMemento
    {
        private IOriginator _originator;
        private string _url;
        public URLSnapshot (IOriginator originator, string url)
        {
            _originator = originator;
            _url = url;
        }
        public void Restore()
        {
            _originator.SetState(_url);
        }
    }
}
