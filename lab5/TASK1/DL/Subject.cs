using System.Collections.Generic;
using UAMS.BL;

namespace UAMS.DL
{
    public static class SubjectDL
    {
        public static List<Subject> Subjects = new List<Subject>();

        public static void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}
