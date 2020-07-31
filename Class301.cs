using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class301
    {
        static void Main()
        {
            A301 va = new A301();
            va.x = 10;
            va.y = 20;
            Console.WriteLine(va.getSum());

            va.setXY(100, 200);
            Console.WriteLine(va.getSum());

            int[] v2 = new int[2] { 11, 22 };
            va.setXY(v2);

            string[] v3 = new string[2] { "100", "200" };
            va.setXY(v3);

            A301 va2 = new A301();
            va2.setXY(1111, 2222);
            va.setXY(va2);

            A301 va3 = new A301(55, 66); // Constructor value
            Console.WriteLine(va3.getSum());
            va3.x = 88;
            Console.WriteLine(va3.getSum());

            Console.ReadKey();
        }//Method Main

    }//Class301
    class A301
    {
        //input val.
        public int x;
        public int y;

        //constructor
        public A301()//Constructor default value
        {
            setXY(0, 0);
        }
        public A301(int x,int y)//Constructor input value at new object
        {
            setXY(x, y);
        }

        public void setXY(int a,int y)//set function
        {
            x = a;
            //y = y; // ชื่อตัวแปรซ้ำกัน
            this.y = y;
        }

        public void setXY(string x, string y)
        {
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);
            setXY(a, b);
        }
        public void setXY(int[] data)
        {
            setXY(data[0], data[1]);
        }
        public void setXY(string[] data)
        {
            setXY(data[0], data[1]);
        }
        public void setXY(A301 va)
        {
            setXY(va.x, va.y);
        }
        public int getSum()//process , get function
        {
            return x + y;
        }
    }//A301
}
