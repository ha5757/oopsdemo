using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock11
{
    class Exercise
    {
        public static int poly(int x, IEnumerable<int> coeffs)
        {
            int cnt = coeffs.Count();
            int result = coeffs.Aggregate(0,(Total, n)=>{
                int c = (int)Math.Pow(x, --cnt);
                Total = Total + c * n;
                return Total;
            });
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 2;
            //IEnumerable<int> E = new int[] { 3, 4, 5 };
            int i = 0;
            String s = "2,[3,4,5]";
            string[] sp = s.Split('[');
            int x = int.Parse(sp[0].Split(',')[0]);
            String[] sp1 = sp[1].Split(',');
            int[] a = new int[sp1.Length];
            for(i=0;i<a.Length-1;i++)
            {
                a[i] = int.Parse(sp1[i]);
            }
            a[i] = int.Parse(sp1[i].Split(']')[0]);
            IEnumerable<int> E = a;
            Console.WriteLine(Exercise.poly(x, E));
            Console.ReadLine();
        }
    }
}
