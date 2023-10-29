using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.ActorClasses
{
    public class Originator
    {
        private string _State;

        public string SetState
        {
            set { _State = value; }
        }

        public string GetState
        {
            get { return _State; }
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(_State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            _State = memento.GetState;
        }
    }
}
