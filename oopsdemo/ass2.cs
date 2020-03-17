using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class ass2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int i = int.Parse(Console.ReadLine());
            print(i);
            Console.Read();
        }
        public static void print(int num)
        {
            int n = 1, count = -1;
            while (n <= num)
            {
                n = n * 2;
                count++;
            }
            int rem = num%2;
            string str = "";
            for (int i = 0; i < count; i++)
            {
                str = str + "2";
            }
            str = str + rem;
            Console.WriteLine(str);
        }
    }
}
