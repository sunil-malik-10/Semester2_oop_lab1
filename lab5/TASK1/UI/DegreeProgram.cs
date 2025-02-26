using System;
using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
  
    public static class DegreeProgramUI
    {
       
        public static void AddDegreeProgram()
        {
              Console.Write("Enter Degree Program Name: ");
               string name = Console.ReadLine();

              DegreeProgram program = new DegreeProgram(name);
              DegreeProgramDL.AddProgram(program);

              Console.WriteLine("Degree Program Added!");
        }
    }
}
