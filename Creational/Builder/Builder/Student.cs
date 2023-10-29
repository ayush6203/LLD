using Builder.BuilderClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Student
    {
        int RollNo;
        int Age;
        string Name;
        string FatherName;
        string MotherName;
        List<string> Subjects;

        public Student(StudentBuilder builder)
        {
            RollNo = builder.RollNo;
            Age = builder.Age;
            Name = builder.Name;
            FatherName = builder.FatherName;
            MotherName = builder.MotherName;
            Subjects = builder.Subjects;
        }
    }
}
