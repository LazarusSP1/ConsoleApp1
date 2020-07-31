using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class304
    {
        static void Main()
        {
            A304 va = new A304();

            B304 vb = new B304(10,20,30);

            C304 vc = new C304();


            D304 vd = new D304();

            Console.WriteLine(va.getSum());
            Console.WriteLine("--------------");
            Console.WriteLine(vb.getSum());
            Console.WriteLine("--------------");
            Console.WriteLine(vc.getSum());
            Console.WriteLine("--------------");
            Console.WriteLine(vd.getSum());
            Console.WriteLine("--------------");


            //Polymorph
            A304 va2 = vb;
            B304 vb2 = (B304)va2;//castsing convert
            va = vb;
            va = vc;
            va = vd;

            //convert
            int a = 10;
            double b = a; //auto
            int c = (int)b;//castsing
            string d1 = c.ToString();//function
            string d2 = Convert.ToString(c);//function
            string d3 = "" + c;//operator convert


        



            Console.ReadKey();

        }//Method main

    }
    class A304
    {
        public int x = 1;
        public int y = 2;

        public int getX(){return x;}
        public int getY() { return y; }
        public virtual int getSum() { return x+y; }
    }// class A
    class B304 : A304
    {
        //รับ x,y ,getX(),getY(),getSum() มาจาก class แม่
        public int z = 3;
        public B304(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override int getSum() { return x + y + z; }

    }// class B

    class C304 : B304
    {
        //public C304() { }
        //public C304() : base() { }
        public int w;
        //public C304() : base(0, 0, 0) { this.w =0 } // กำหนด default constructor และ สร้าง w =0 เป็น default เมื่อสร้าง object
        public C304() : this(0, 0, 0, 0) { }
        public C304(int x, int y, int z, int w) : base(x, y, z) { this.w = w; }
        public override int getSum()
        {
            return x + y + z +w;
        }
    }
    class D304 : C304
    {
        //public D304 :base() { }
    }

}
