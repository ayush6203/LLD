using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IStudent
    {
        void CreateStudent(string user);
        void DeleteStudent(string user, int id);
        void GetStudent(string user, int id);
    }
}
