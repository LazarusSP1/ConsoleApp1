using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class302
    {
        static void Main()
        {
            A302 va = new A302();
            va.x = 10;
            va.y = 20;
            Console.WriteLine(va.x);
            Console.WriteLine(va.y);
            Console.WriteLine("-------------");

            B302 vb = new B302();
            vb.setX(11);//encapsulate แล้ว แต่ยังไม่เป็น property
            vb.setY(22);
            Console.WriteLine(vb.getX());
            Console.WriteLine(vb.getY());
            Console.WriteLine("-------------");

            C302 vc = new C302();
            vc.x = 100; // ไม่ต้องมี () เพราะเป็น property แล้ว
            vc.y = 200;
            Console.WriteLine(vc.x);
            Console.WriteLine(vc.y);
            Console.WriteLine("-------------");

            D302 vd = new D302();
            vd.x = 100; // ไม่ต้องมี () เพราะเป็น property แล้ว
            vd.y = 200;
            Console.WriteLine(vd.x);
            Console.WriteLine(vd.y);
            Console.WriteLine("-------------");

            Console.ReadKey();
        }//Method main


    }//class302

    class A302
    {
        public int x = 1;//field
        public int y = 2;//field

    }//A302 class---------------------
    class B302
    {
        private int x = 1;//field
        private int y = 2;//field

        
        public void setX(int x)//encapsulate 
        {
            this.x = x;
        }
        public void setY(int y)//encapsulate 
        {
            this.y = y;
        }
        public void setXY(int x, int y)//overloading
        {
            setX(x);
            setY(y);
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }//B302 class---------------------
    class C302
    {
        private int _x = 1;//field
        private int _y = 2;//field
        public int x { set; get; }//property
        public int y { set; get; }//property
    }
    class D302
    {
        private int _x = 1;//field
        private int _y = 2;//field
        public int x {//full stack property
            set { _x = value; }
            get { return _x; }
        }//property
        public int y {//full stack property
            set {_y=value; }
            get {return _y; }
        }//property
        public int getSum()
        {
            //return _x + _y; //
            return x + y;  // เขียนได้ 2 แบบ แต่นิยมใช้เรียกจากนอก obj.
        }
    }
}//Namespace
