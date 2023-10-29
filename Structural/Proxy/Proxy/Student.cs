using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Student : IStudent
    {
        public void CreateStudent(string user)
        {
            Console.WriteLine("Student got created by " + user);
        }

        public void DeleteStudent(string user, int id)
        {
            Console.WriteLine(id + " Student got deleted by " + user);
        }

        public void GetStudent(string user, int id)
        {
            Console.WriteLine("Here is the student : " + id + " by " + user);
        }
    }
}
