using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock7
{
    class maincc
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("Enter contact 1 detail:");
            string S = Console.ReadLine();
            Console.WriteLine("Enter contact 2 detail:");
            string S1 = Console.ReadLine();
            String[] S2 = S.Split(',');
            String[] S3 = S1.Split(',');
            Contact c1 = new Contact(S2[0],S2[1],S2[2],S2[3],S2[4],S2[5],DateTime.ParseExact(S2[6],"dd-MM-yyyy",CultureInfo.InvariantCulture));
            Contact c2 = new Contact(S3[0], S3[1], S3[2], S3[3], S3[4],S3[5],DateTime.ParseExact(S3[6],"dd-MM-yyyy",CultureInfo.InvariantCulture));
            Console.WriteLine("\n");
            Console.WriteLine("Contact 1:");
            Console.WriteLine(c1);
            Console.WriteLine("\n");
            Console.WriteLine("Contact 2:");
            Console.WriteLine(c2);
            Console.WriteLine("\n");
            if (c1.Equals(c2))
                Console.WriteLine("Contact 1 is same as Contact 2");
            else
                Console.WriteLine("Contact 1 and Contact 2 are different");
            Console.Read();
        }
    }
}
