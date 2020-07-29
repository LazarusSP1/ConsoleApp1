using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class102
    {
        static void Main()
        {
            Email2 v = new Email2(); // เรียก function
            v.email = "admin@rtaf.mi.th";
            Console.WriteLine(v.getName());
            Console.WriteLine(v.getDomain());
            Console.WriteLine(v.getLenght());
            Console.ReadKey();
        }//method main
    }//class
}
