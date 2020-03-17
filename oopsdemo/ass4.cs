using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class ass4
    {
        public static int f1(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int rem = x % 10;
                
                result = result * 10 + rem;
                x = x / 10;
            }
            return result;
        }

            static void Main(string[] args)
        {
            int y=0;
            Console.WriteLine("enter a number");
            int s =int.Parse(Console.ReadLine());
            int x=f1(s);
            Console.WriteLine(x);
            if (s>x)
            {
                y = s - x;
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.Read();

        }
    }
}
