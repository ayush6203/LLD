using Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class NameRepository : IContainer
    {
        public string[] Names = { "Julie", "Robert", "John", "Mintodari" };
        public IIterator GetIterator()
        {
            return new NameIterator(this);
        }

        private class NameIterator : IIterator
        {
            NameRepository _outerClass;
            int index = 0;

            public NameIterator(NameRepository outer)
            {
                _outerClass = outer;
            }

            public bool HasNext()
            {
                if (index < _outerClass.Names.Length)
                    return true;

                return false;
            }

            public object Next()
            {
                if (this.HasNext())
                    return _outerClass.Names[index++];

                return null;
            }
        }
    }
}
