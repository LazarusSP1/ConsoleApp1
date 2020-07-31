using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class306
    {
        static void Main()
        {
            B306 vb = new B306();
            C306 vc = new C306();

            show(vb);
            show(vc);

            //interface ส่ง
            D306 vd;
            vd = new E306();//polymorph
            vd.print();
            vd.show();

            Console.ReadKey();

        }//method main
        static void show(A306 va)
        {
            va.open();
            va.close();
        }
        
    }
    abstract class A306
    {
        public int x = 10;
        public int getX() { return x; }
        public abstract void open();
        public abstract void close();
    }
    class B306 : A306
    {
        public override void close()
        {
            Console.WriteLine("B306:closed()");
        }

        public override void open()
        {
            Console.WriteLine("B306:open()");
        }
    }
    class C306 : A306
    {
        public override void close()
        {
            Console.WriteLine("C306:closed()");
        }

        public override void open()
        {
            Console.WriteLine("C306:open()");
        }
    }//class c

    //interface ท่อ
    interface D306
    {
        void show();
        void print();
    }
    class E306 : D306 // interface รับ
    {
        public void show()
        {

        }
        public void print()
        {

        }
    }

}
