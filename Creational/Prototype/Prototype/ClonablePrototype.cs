using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class ClonablePrototype<T>
    {
        //Shallow Copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }


        //Deep Copy
        public T DeepClone()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
