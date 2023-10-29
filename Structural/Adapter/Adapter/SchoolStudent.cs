using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SchoolStudent
    {
        private string Name;
        private string Surname;
        private string Email;

        public SchoolStudent(string firstName, string lastName, string emailAddress)
        {
            this.Name = firstName;
            this.Surname = lastName;
            this.Email = emailAddress;
        }

        public string GetEmailAddress()
        {
            return this.Email;
        }

        public string GetFirstName()
        {
            return this.Name;
        }

        public string GetLastName()
        {
            return this.Surname;
        }
    }
}
