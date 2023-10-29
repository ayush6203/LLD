using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SchoolStudentAdapter : IStudent
    {
        private SchoolStudent schoolStudent;

        public SchoolStudentAdapter(SchoolStudent schoolStudent)
        {
            this.schoolStudent = schoolStudent;
        }

        public string GetEmail()
        {
            return this.schoolStudent.GetEmailAddress();
        }

        public string GetName()
        {
            return this.schoolStudent.GetFirstName();
        }

        public string GetSurname()
        {
            return this.schoolStudent.GetLastName();
        }
    }
}
