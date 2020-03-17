using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class assg6
    {
        static int GCD(int num1, int num2)
        {
            int Remainder;

            while (num2 != 0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }

            return num1;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter the First Number : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            y = int.Parse(Console.ReadLine());
            Console.Write("\nThe Greatest Common Divisor of ");
            Console.WriteLine("{0} and {1} is {2}", x, y, GCD(x, y));


            int A = GCD(x, y);
            int B = x / A;
            int C = y / A;                                                                                    
            Console.WriteLine(B + "/" + C);
            Console.ReadLine();

        }
    }
}
