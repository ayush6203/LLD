using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes
{
    public sealed class ThreadSafeWithoutLazySingleton
    {
        private static readonly ThreadSafeWithoutLazySingleton _instance = new ThreadSafeWithoutLazySingleton();
        static ThreadSafeWithoutLazySingleton() { }

        public static ThreadSafeWithoutLazySingleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
