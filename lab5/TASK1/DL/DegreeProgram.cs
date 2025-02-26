using System.Collections.Generic;
using UAMS.BL;

namespace UAMS.DL
{
    public static class DegreeProgramDL
    {
        public static List<DegreeProgram> Programs = new List<DegreeProgram>();

        public static void AddProgram(DegreeProgram program)
        {
            Programs.Add(program);
        }
    }
}
