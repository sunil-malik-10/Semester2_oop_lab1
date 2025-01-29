using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class task7
    {
        static void print(string[] args)
        {
            String str;
            Console.WriteLine("Enter Floating Point Value: ");
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("The floating value is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        }
}
