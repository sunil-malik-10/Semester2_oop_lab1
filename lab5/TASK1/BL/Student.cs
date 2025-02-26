using System.Collections.Generic;



namespace UAMS.BL
{
    public class Student
    {
        public string Name { get; set; }
        public DegreeProgram Program { get; set; }//degreeprogram
        public List<Subject> EnrolledSubjects { get; set; }

        public Student(string name, DegreeProgram program)
        {
            Name = name;
            Program = program;
            EnrolledSubjects = new List<Subject>();
        }

        public void RegisterSubject(Subject subject)
        {
            EnrolledSubjects.Add(subject);
        }
    }
}
