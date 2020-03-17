using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock8
{
    class mainsa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Email Validation");
            Console.WriteLine("2.Service Provider Identification");
            Console.WriteLine("Enter your choice:");
            int ch=int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the email to be validated:");
                    string v = Console.ReadLine();
                    //Program p = new Program();
                    if (Program.ValidateEmailId(v) == true)
                        Console.WriteLine("Email is valid");
                    else
                        Console.WriteLine("Email is invalid");
                    break;
                case 2:
                    Console.WriteLine("Enter the mobile number to identify the service provider:");
                    string x = Console.ReadLine();
                    //Program p1 = new Program();
                    Console.WriteLine(Program.IdentifyServiceProvider(x));
                    break;
            }
            Console.Read();

        }
    }
}
