using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    interface Intf
    {
        void Method1();
        void Method2();
    }
    abstract class Demo : Intf
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public abstract void Method2();

    }
    class DChild : Demo
    {
        public override void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
        class class2
    {
            static void Main(string[] args)
            {
                Intf I = new DChild();
                I.Method1();
                I.Method2();
                Console.Read();
            }
        }
}
