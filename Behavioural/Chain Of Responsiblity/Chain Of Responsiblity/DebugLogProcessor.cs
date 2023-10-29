using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsiblity
{
    public class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor logProcessor) : base(logProcessor)
        {
        }

        public override void Log(int loglevel, string message)
        {
            if (loglevel == DEBUG)
            {
                Console.WriteLine("DEBUG : " + message);
                return;
            }

            base.Log(loglevel, message);
        }
    }
}
