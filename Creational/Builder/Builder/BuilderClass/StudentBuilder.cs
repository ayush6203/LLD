using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderClass
{
    public abstract class StudentBuilder
    {
        public int RollNo;
        public int Age;
        public string Name;
        public string FatherName;
        public string MotherName;
        public List<string> Subjects;

        public StudentBuilder SetRollNumber(int rollNum)
        {
            this.RollNo = rollNum;
            return this;
        }

        public StudentBuilder SetAge(int age)
        {
            this.Age = age;
            return this;
        }

        public StudentBuilder SetName(string name)
        {
            this.Name = name;
            return this;
        }

        public StudentBuilder SetFatherName(string fatherName)
        {
            this.FatherName = fatherName;
            return this;
        }

        public StudentBuilder SetMotherName(string motherName)
        {
            this.MotherName = motherName;
            return this;
        }

        abstract public StudentBuilder SetSubjects();

        public Student Build()
        {
            return new Student(this);
        }
    }
}
