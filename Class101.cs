using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class101
    {
        static void Main()
        {
            Console.WriteLine("Hello!");

            string email = "aadmin@rtaf.mi.th";
            /*Console.WriteLine(email);
            Console.WriteLine(email.Length);
            Console.WriteLine(email.Substring(2,4));
            Console.WriteLine(email.IndexOf('@'));
            Console.WriteLine(email.IndexOf('z'));
            
            Console.WriteLine(email.Substring(0,email.IndexOf('@')));
            Console.WriteLine(email.Substring(email.IndexOf('@')+1));

            Console.WriteLine(getName(email));
            Console.WriteLine(getDomain(email));
            */

            Console.WriteLine(Email.getName(email));
            Console.WriteLine(Email.getDomain(email));

            Console.ReadKey();
        }//Method

    }//Class
    class Email
    {
        public static string getName(string em)
        {
            return em.Substring(0, em.IndexOf('@'));
        }
        public static string getDomain(string dm)
        {
            return dm.Substring(dm.IndexOf('@') + 1);
        }
    }
}//namespace
