using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Email2
    {
        public string email; // input value

        public string getName()
        {
            return email.Substring(0, email.IndexOf('@'));
        }//method getName
        public string getDomain()
        {
            return email.Substring(email.IndexOf('@') + 1);
        }
        public int getLenght()
        {
            return email.Length;
        }
    }//class Email2
}
