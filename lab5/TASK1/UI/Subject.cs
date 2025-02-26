
using System;
using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
   
    public static class SubjectUI
    {
            
        public static void AddSubject()
        {
            Console.Write("Enter Code of Subject: ");
            string Code = Console.ReadLine();
            Console.Write("Enter Name of Subject : ");
            string name = Console.ReadLine();

            Subject subject = new Subject(Code, name);
            SubjectDL.AddSubject(subject);

            Console.WriteLine("Subject Added!");
        }
    }
}
