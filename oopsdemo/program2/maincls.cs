using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.program2
{
    class maincls
    {
        static void Main(string[] args)
        {
            empp e = new empp();
            e.Accept(10, "ram", 50000);
            e.print();
            e = new empp();
            e.Accept(20, "ravi", 60000);
            e.print();
            Console.Read();
        }
    }
}
