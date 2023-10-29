using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsiblity
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor logProcessor) : base(logProcessor)
        {

        }

        public override void Log(int loglevel, string message)
        {
            if (loglevel == ERROR)
            {
                Console.WriteLine("ERROR : " + message);
                return;
            }

            base.Log(loglevel, message);
        }
    }
}
