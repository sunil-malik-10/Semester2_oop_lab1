using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace week1
{
    internal class task8
    {
        static void Main(string[] args)
        {
            string input;
            float marks;
            Console.Write("Enter your marks: ");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("You have passed the exam");
            }
            else
            {
                Console.WriteLine("You have failed the exam");
            }
            Console.Read();
        }
    }
}
