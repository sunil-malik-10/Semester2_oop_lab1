using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class task6
    {
        static void Print(string[] args)
        {
            String str;
            str = Console.ReadLine();
            Console.WriteLine("You have entered: ");
            int num = int.Parse(str);
            Console.WriteLine("The number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
    }
}
