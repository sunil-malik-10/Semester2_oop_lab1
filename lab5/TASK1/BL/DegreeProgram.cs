using System.Collections.Generic;

namespace UAMS.BL
{
    public class DegreeProgram
    {
        public string name;
        public List<Subject> Subjects;

        public DegreeProgram(string name)
        {
            this.name = name;
            Subjects = new List<Subject>();
        }
    }
}
