using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CollegeStudent : IStudent
    {
        private string Name;
        private string Surname;
        private string Email;

        public CollegeStudent(string name, string surname, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetSurname()
        {
            return this.Surname;
        }
    }
}
