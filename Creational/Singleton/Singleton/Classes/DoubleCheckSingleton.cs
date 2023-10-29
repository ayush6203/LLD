using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes
{
    public sealed class DoubleCheckSingleton
    {
        private static readonly object _lock = new object();
        private static DoubleCheckSingleton _instance = null;
        private DoubleCheckSingleton() { }

        public static DoubleCheckSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new DoubleCheckSingleton();
                    }
                }

                return _instance;
            }
        }
    }
}
