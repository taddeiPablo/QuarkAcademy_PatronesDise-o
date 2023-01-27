using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoCoreLibrary
{
    public class CareTaker
    {
        private List<Memento> _mementos = new List<Memento>();

        public void add(Memento memento)
        {
            _mementos.Add(memento);
        }
        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
