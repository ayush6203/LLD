using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsiblity
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor logProcessor) : base(logProcessor)
        {
        }

        public override void Log(int loglevel, string message)
        {
            if(loglevel == INFO)
            {
                Console.WriteLine("INFO : " + message);
                return;
            }

            base.Log(loglevel, message);
        }
    }
}
