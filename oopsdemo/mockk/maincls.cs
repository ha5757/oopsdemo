using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oopsdemo.mockk
{
    class maincls
    {
        static void Main(string[] args)
        {
            BillValidator bb = new BillValidator();
            ElectricityBill ebill = new ElectricityBill();
            bb.ValidateUnitsConsumed(ebill.UnitsConsumed);
            Console.WriteLine("Enter Number of Bills To Be Added :");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               // ElectricityBill ebill = new ElectricityBill();
                Console.WriteLine("Enter Consumer Number:");
                string c = Console.ReadLine();
                try
                {
                    string temp =@"^[E][B][0-9]{5}$";
                    Regex R = new Regex(temp);
                    if (!R.IsMatch(c))
                    {
                        throw new Exception("Invalid Consumer Number");
                    }
                    else
                    {
                        ebill.ConsumerNumber = c;
                        Console.WriteLine("Enter Consumer Name:");
                        string s = Console.ReadLine();
                        ebill.ConsumerName = s;
                        Console.WriteLine("Enter Units Consumed:");
                        int u = int.Parse(Console.ReadLine());
                        ebill.UnitsConsumed = u;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Enter Last 'N' Number of Bills To Generate");
            int num = int.Parse(Console.ReadLine());
            ElectricityBoard eb = new ElectricityBoard();
            
            eb.CalculateBill(ebill);
            eb.AddBill(ebill);

            List<ElectricityBill> El =  eb.Generate_N_BillDetails(num);



        }
    }
}
