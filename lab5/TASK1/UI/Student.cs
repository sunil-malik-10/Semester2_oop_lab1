using System;

using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
    public static class StudentUI
    {
        public static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Available Degree Programs:");
            foreach (var program in DegreeProgramDL.Programs)
            {
                Console.WriteLine(program.name);
            }

            Console.Write("Enter Degree Program Name: ");
            string programName = Console.ReadLine();
            DegreeProgram selectedProgram = DegreeProgramDL.Programs.Find(p => p.name == programName);

            if (selectedProgram != null)
            {
                Student student = new Student(name, selectedProgram);
                StudentDL.AddStudent(student);
                Console.WriteLine("Student Registered!");
            }
            else
            {
                Console.WriteLine("Degree Program Not Found!");
            }
        }
    }
}
