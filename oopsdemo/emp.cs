using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class emp
    {
       public int empno;
        public string ename;
        public double basic;
        //member functions
       public void print()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("ename" + ename);
            Console.WriteLine("basic" + basic);
        }
    }
}
