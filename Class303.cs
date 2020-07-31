using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class303
    {
        static void Main()
        {
            A303 va = new A303(100,200);
            Console.WriteLine(va.getSum());

            A303 va2 = new A303(10);
            Console.WriteLine(va2.getSum());
            Console.WriteLine("---------");

            B303 vb = new B303();
            vb.setXY(111, 222);
            vb.z = 333;
            Console.WriteLine(vb.getSum());
            Console.WriteLine(vb.getSum3());

            Console.ReadKey();
        }
    }
    class A303
    {
        public int x;
        public int y;

        //public A303() {} // default constructor

        public A303() { x = 0;y = 0; }

        public A303(int x,int y)
        {
            //this.x = x;
            //this.y = y;
            setXY(x, y);
        }

        public A303(int x) : this(x, 0) { } // Call Constructor

        public void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;            
        }
        public int getSum() { return x + y; }
    }//class A
    class B303:A303 // Interit class
    {
        public int z;
        public int getSum3()
        {
            //return x + y + z;
            //return this.x + this.y + this.z;
            return this.getSum() + this.z;
        }
    }//class B
}
