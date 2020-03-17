using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //early binding
            emp e = new emp();
            e.empno = 10;
            e.ename = "ram";
            e.basic = 2000;
            emp e1 = new emp();
            e1.empno = 20;
            e1.ename = "ravi";
            e1.basic = 6000;
            emp e2 = new emp();
            e2.print();
            e.print();
            e1.print();
            e.print();
            Console.Read();
        }
    }
}
