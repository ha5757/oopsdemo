using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock5
{
    class mainc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the vehicles:");
            int n = int.Parse(Console.ReadLine());
            List<Vehicle> L = new List<Vehicle>();
            for(int i=0;i<n;i++)
            {
                string s = Console.ReadLine();
                L.Add(Vehicle.CreateVehicle(s));
            }
            Console.WriteLine("Enter a type to sort:");
            Console.WriteLine("1.Sort by weight\n2.Sort by parked time ");
            int ch=int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    L.Sort();
                    Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}","RegistrationNo","Name","Type","Weight","TicketNo");
                    foreach(var v in L)
                    {
                        Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", v.RegistrationNo, v.Name, v.Type, v.Weight, v.Ticket.TicketNo);
                    }
                    break;
                case 2:
                    parkedTimeComparer h = new parkedTimeComparer();
                    Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", "RegistrationNo", "Name", "Type", "Weight", "TicketNo");
                    L.Sort(h);
                    foreach (var x in L)
                    {
                        Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", x.RegistrationNo, x.Name, x.Type,x.Weight,x.Ticket.TicketNo);
                    }
                    break;
            }
            Console.Read();
        }
    }
}
