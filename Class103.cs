using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class103
    {
        static void Main()
        {
            Interest v = new Interest();

            v.setData(20000, 0.3, 3);
            Console.WriteLine("amount: " + v.amount.ToString() + "\nrate: " + v.rate.ToString() + "\ntime: " + v.time.ToString());
            Console.WriteLine(v.getInterest());
            Console.WriteLine(v.getTax());
            Console.WriteLine(v.getNet());
            Console.WriteLine("=============");


            Console.ReadKey();
        }
    }
}
