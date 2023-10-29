using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderClass
{
    public class EngineerStudentBuilder : StudentBuilder
    {
        public override StudentBuilder SetSubjects()
        {
            List<string> subjects = new List<string>() { "DAA", "DBMS"};
            this.Subjects = subjects;
            return this;
        }
    }
}
