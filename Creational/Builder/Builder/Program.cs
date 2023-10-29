using Builder;
using Builder.BuilderClass;

StudentBuilder studentBuilder = new EngineerStudentBuilder();
Student studentObj = studentBuilder.SetRollNumber(4).SetName("Ayush").SetSubjects().Build();

Console.ReadKey();
