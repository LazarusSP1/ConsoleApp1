using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Class201
    {
        static void Main()
        {
            int[] a = new int[3];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            Console.WriteLine(a);
            Console.WriteLine(a[0]);
            Console.WriteLine(a.Length);

            int[] b = new int[] { 11, 22, 33 };
            int[] c = { 11, 22, 33 };
            int[] d = c; //รับค่าจาก Arrray หรือ fn ที่ return เป็น array

            Console.WriteLine("===========================");

            //string[] rows = File.ReadAllLines("C:\\data\\data.txt");
            string[] rows = File.ReadAllLines(@"C:\data\data.txt",Encoding.UTF8);
            Console.WriteLine(rows.Length);

            for(int i =0; i < rows.Length; i++)
            {
                Console.WriteLine(rows[i]);
            }

            Console.ReadKey();
        }
    }
}
