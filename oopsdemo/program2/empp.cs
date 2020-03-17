using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.program2
{
    class empp
    {
        int empno;
        string ename;
        double basic;
        public void Accept(int empno,string ename,double basic)
         {
            this.empno=empno;
            this.ename=ename;
            this.basic=basic;
          }
    public void print()
    {
        Console.WriteLine("empno" + empno);
        Console.WriteLine("ename" + ename);
        Console.WriteLine("basic" + basic);
    }
    }


}