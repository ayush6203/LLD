using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class StudentProxy : IStudent
    {
        IStudent studentObj = new Student();

        public void CreateStudent(string user)
        {
            if (user == "ADMIN")
                studentObj.CreateStudent(user);
            else
                Console.WriteLine("Student cannont be created by " + user);
        }

        public void DeleteStudent(string user, int id)
        {
            if (user == "ADMIN")
                studentObj.DeleteStudent(user, 4);
            else
                Console.WriteLine("Student cannot be deleted by " + user);
        }

        public void GetStudent(string user, int id)
        {
            studentObj.GetStudent(user, id);
        }
    }
}
