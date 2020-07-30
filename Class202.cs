using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class202
    {
        static void Main()
        {
            TextData db = new TextData();
            Email2 em = new Email2();
            Interest vi = new Interest();
            db.filename = @"c:\data\data.txt";
            db.openData();
            vi.setRate(10);
            vi.time = 1;
            Console.WriteLine(vi.getRate());
            while (!db.eof)
            {
                em.email = db.getColumn(1);
                //vi.setData(db.getColumn(2), 0.1, 1);
                vi.amount = Convert.ToDouble(db.getColumn(2));
                Console.WriteLine(db.getColumn(0));
                Console.WriteLine(db.getColumn(1));
                Console.WriteLine(db.getColumn(2));
                Console.WriteLine(em.getName());
                Console.WriteLine(em.getDomain());

                Console.WriteLine("=================");
                db.moveNext();
            }
            Console.ReadKey();
        }
    }
}
