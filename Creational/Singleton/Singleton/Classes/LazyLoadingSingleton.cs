using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes
{
    public sealed class LazyLoadingSingleton
    {
        private static readonly Lazy<LazyLoadingSingleton> _instance = new Lazy<LazyLoadingSingleton>(() => new LazyLoadingSingleton());
        private LazyLoadingSingleton() { }

        public static LazyLoadingSingleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
