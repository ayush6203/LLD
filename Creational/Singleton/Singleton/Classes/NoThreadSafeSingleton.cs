using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes
{
    public sealed class NoThreadSafeSingleton
    {
        private static NoThreadSafeSingleton _instance = null;
        private NoThreadSafeSingleton() { }

        public static NoThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NoThreadSafeSingleton();

                return _instance;
            }
        }
    }
}
