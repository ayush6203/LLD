using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.FileSystem
{
    public class Directory : IFileManager
    {
        public List<IFileManager> ltFileManager = new List<IFileManager>();

        public void ls()
        {
            foreach (var o in ltFileManager)
                o.ls();
        }
    }
}
