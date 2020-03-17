using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class _3assg3
    {
        static void Main(string[] args)
        {
            int[] a = { 20, 10, 70, 50, 30 };
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            string s = "pranitha";
            //function1
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            Console.WriteLine(ch);
            //function2:converting char array to string
            char[] c = { 'B', 'A', 'J', 'A', 'J' };
            string str = new string(c);
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            string S = "Myname is Pranitha";
            //Console.WriteLine(S.ToUpper());
            Console.WriteLine(S);
            S = S.ToUpper();
            Console.WriteLine(S);
            //split function
            string s1 = "item1,item2,item3,item4,item5";
            string[] I = s1.Split(',');
            for (int i = 0; i < I.Length; i++)
            {
                Console.WriteLine(I[i]);
            }
            string s2 = S.Substring(0, 6);
            Console.WriteLine(s2);
            char[] p = S.ToCharArray();
            Array.Reverse(p);
            Console.WriteLine(new string(p));
            //trim
            string s3 = "Pranitha ";
            Console.WriteLine(s3.Trim().Length);
            Console.WriteLine(s3.StartsWith("Pra"));
            Console.WriteLine(s3.EndsWith("tha "));
            string s4 = "baj.aj@gmail.com";
            Console.WriteLine(s4.IndexOf("."));
            Console.WriteLine(s4.LastIndexOf("."));
            string s5 = "hello";
            string s6 = "Hello";
            if (s5.ToUpper().Equals(s6.ToUpper()))
            {
                Console.WriteLine("Y");
            }
            else
                Console.WriteLine("N");
            Console.WriteLine(s3.Contains("ant"));
            Console.Read();

        }
    }
}
