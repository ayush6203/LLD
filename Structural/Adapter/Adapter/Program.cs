//College Student Class is new generation class which is compatable with IStudent interface.
//School Student Class in Old generation class which is non compatable with IStudent interface.

using Adapter;

List<IStudent> ltStudent = new List<IStudent>();
CollegeStudent collegeStudent = new CollegeStudent("ayush","singh","ayush6203@gmail.com");
ltStudent.Add(collegeStudent);

SchoolStudent schoolStudent = new SchoolStudent("piyush", "singh", "piyush6203@gmail.com");
ltStudent.Add(new SchoolStudentAdapter(schoolStudent));

