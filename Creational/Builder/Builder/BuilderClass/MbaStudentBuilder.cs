using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderClass
{
    public class MbaStudentBuilder : StudentBuilder
    {
        public override StudentBuilder SetSubjects()
        {
            List<string> subjects = new List<string>() { "Business", "Economics", "Speaking" };
            this.Subjects = subjects;
            return this;
        }
    }
}
