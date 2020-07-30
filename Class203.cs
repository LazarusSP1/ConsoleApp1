using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class203
    {
        static void Main()
        {
            //การใช้งาน static ใน class A203
            A203.x = 111;
            Console.WriteLine(A203.x);
            Console.WriteLine(A203.getX());
            Console.WriteLine("-----------------");

            //การใช้งาน non-static ใน class A203
            A203 va = new A203();
            va.y = 222;
            Console.WriteLine(va.y);
            Console.WriteLine(va.getY());
            Console.WriteLine(va.getSum2());

            Console.ReadKey();
        }//method


    }//class

    class A203
    {
        public static int x = 10;
        public int y = 20;
        public static int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        /*
        public static int getSum1()
        {
            return x + y;
        }
        */
        public int getSum2()
        {
            return x + y;
        }

    }
}
