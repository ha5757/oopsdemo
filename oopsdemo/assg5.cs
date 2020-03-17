using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class assg5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(calculate(n, a, b));
            Console.ReadLine();
        }
        static int calculate(int n, int a, int b)
        {
            int cnt = 0;
            double p;
            int i = 1;
            //p = Math.Pow(i, n);
            while (i <= Math.Sqrt(b))
            {
                p = Math.Pow(i, n);
                if (p >= a && p <= b)
                {
                    cnt++;
                }

                i++;

            }
            return cnt;
        }
    }
}
