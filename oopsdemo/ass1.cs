using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class ass1
    {
        //"A4B5C2" ➞ "AAAABBBBBCC"
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int num;
            char c;
            string str = string.Empty;
            for (int i = 0; i < s.Length; i = i + 2)
            {
                str = string.Empty;
                if (i % 2 == 0)
                {
                    c = s[i];
                    num = int.Parse(s[i + 1].ToString());
                    for (int j = 0; j < num; j++)
                    {
                        str += c;
                    }
                    Console.Write(str);
                }

            }
            Console.ReadLine();
        }
    }
}
