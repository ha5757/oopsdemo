using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class _3ass1
    { 
        public static int F1(int x)
        {
            int sum = 0;
            while(x!=0)
            {
                int y = x % 10;
                sum = sum + y;
                x = x / 10;

            }
            if(sum>=10)
            {
                sum = (F1(sum));
            }

           return sum;

        }
        //public static int F2(int t)
        //{
        //    if (t >= 10)
        //    {
        //        int sum = 0;
        //        while (t != 0)
        //        {
        //            int y = t % 10;
        //            sum = sum + y;
        //            t = t / 10;

        //        }
        //        return sum;
        //    }
        //    else
        //        return t;

         

        //}
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("enter the membership id");
            s = int.Parse(Console.ReadLine());
            int z=F1(s);
           // int v=F2(z);
            //if(z >= 10)
            //{
            //    F1(z);
            //}
            //else
            //{
                Console.WriteLine(z);
            //}
            Console.Read();
        }
    }
}
