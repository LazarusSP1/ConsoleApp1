using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class204
    {
        static void Main()
        {
            A204 va = new A204();
            Console.WriteLine(va.y+va.v);
            Console.ReadKey();
        }
    }
    class A204
    {
        int x = 1;
        public int y = 2;
        private int z = 3;
        protected int w = 4;
        internal int v = 5;

        public void show()
        {
            Console.WriteLine(x+y+z+w+v);
        }//method show
    }//class A204
    class B204 : A204  //sub-class : base-class
    {
        public void show()
        {
            Console.WriteLine( y +  w + v); // x เป็น private กับ z เป็น private
        }//method show
    }//class B204
}
