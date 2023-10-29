using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.ActorClasses
{
    public class Memento
    {
        private string _State;

        public Memento(string state)
        {
            _State = state;
        }

        public string GetState
        {
            get { return _State; }
        }
    }
}
