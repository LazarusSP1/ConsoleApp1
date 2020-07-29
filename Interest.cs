using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Interest
    {
        public double amount;
        public double rate;
        public double time;

        public void setData(double a, double r, double t)
        {
            amount = a;
            rate = r;
            time = t;
            /*
             * insert data using 
             * setData(amount,rate,time);
            */
        }

        public double getInterest()
        {
            return amount * rate * time;
        }
        public double getTax()
        {
            return getInterest() * 0.15;
        }
        public double getNet()
        {
            return amount + getInterest() - getTax();
        }
    }//class
}
