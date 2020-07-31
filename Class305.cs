using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class305
    {
        static void Main()
        {
            B305 vb = new B305();
            Console.WriteLine(vb.x);
            Console.WriteLine(vb.y);
            Console.WriteLine(vb.z);
            Console.WriteLine(vb.getX());
            Console.WriteLine(vb.getY());
            Console.WriteLine(vb.getZ());
            Console.WriteLine("--------------");

            A305 va = vb;
            Console.WriteLine(va.x);
            Console.WriteLine(va.y);
            //Console.WriteLine(va.z);  // class แม่ไม่มี z
            Console.WriteLine(va.getX());
            Console.WriteLine(va.getY());
            //Console.WriteLine(va.getZ());  // class แม่ไม่มี z
            Console.WriteLine("--------------");

            B305 vb2 = (B305)va;
            Console.WriteLine(vb2.x);
            Console.WriteLine(vb2.y);
            Console.WriteLine(vb2.z);
            Console.WriteLine(vb2.getX());
            Console.WriteLine(vb2.getY());
            Console.WriteLine(vb2.getZ());
            Console.WriteLine("--------------");

            B305 vb51 = new B305();
            B305 vb52 = new B305();
            show(vb51);
            show(vb52);



            Console.ReadKey();
        }//method main
        static void show(B305 vb5)
        {
            Console.WriteLine(vb5.x);
            Console.WriteLine(vb5.y);
            Console.WriteLine(vb5.getX());
            Console.WriteLine(vb5.getY());
            Console.WriteLine("---------------");
        }

    }//class305
    class A305
    {
        public int x = 1;
        public int y = 2;
        public int getX() { return x; }
        public virtual int getY() { return y; }
    }
    class B305:A305
    {
        public int z = 30;
        public int y = 20;
        public int getZ() { return z; }
        public override int getY() { return y; }
    }
    class C305 : A305
    {
        public int w = 300;
        public int y = 200;
        public int getW() { return w; }
        public override int getY() { return y; }
    }
}
