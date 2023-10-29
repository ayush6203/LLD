using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.ActorClasses
{
    public class CareTaker
    {
        IList<Memento> ltMemento = new List<Memento>();

        public void Add(Memento memento)
        {
            ltMemento.Add(memento);
        }

        public Memento Get(int index)
        {
            return ltMemento[index];
        }
    }
}
