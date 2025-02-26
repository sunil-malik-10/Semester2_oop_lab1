using System.Collections.Generic;
using UAMS.BL;


namespace UAMS.DL
{
    public static class StudentDL
    {
        public static List<Student> Students = new List<Student>();

        public static void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
