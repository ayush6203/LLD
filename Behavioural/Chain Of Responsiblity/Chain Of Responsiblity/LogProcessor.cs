using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsiblity
{
    public abstract class LogProcessor
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        private readonly LogProcessor _nextLogProcessor;
        public LogProcessor(LogProcessor logProcessor)
        {
            _nextLogProcessor = logProcessor;
        }

        public virtual void Log(int loglevel, string message)
        {
            if (_nextLogProcessor != null)
                _nextLogProcessor.Log(loglevel, message);
        }
    }
}
