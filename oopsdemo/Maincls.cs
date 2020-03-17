using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Maincls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of vehicles: ");
            int n = int.Parse(Console.ReadLine());
            VehicleBO B = new VehicleBO();
            List<Vehicle> L = new List<Vehicle>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                L.Add(Vehicle.CreateVehicle(s));
            }
            Console.WriteLine("Enter a search type: ");


            Console.WriteLine("1. By type\n 2. By parked time ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the vehicle type ");
                    string s2 = Console.ReadLine();
                    List<Vehicle> L1 = B.FindVehicle(L, s2);
                    Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", "Registration No", "Name", "Type", "Weight", "Ticket No");
                    B.FindVehicle(L, s2);
                    foreach (var i in L1)
                    {
                        Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", i.RegistrationNo, i.Name, i.Type, i.Weight, i.Ticket.TicketNo);
                    }


                    break;
                case 2:
                    Console.WriteLine("Enter the parkedtime ");
                    DateTime s3 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm:ss", null);
                    List<Vehicle> L2 = B.FindVehicle(L, s3);
                    Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", "Registration No", "Name", "Type", "Weight", "Ticket No");
                    B.FindVehicle(L, s3);
                    foreach (var i in L2)
                    {
                        Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", i.RegistrationNo, i.Name, i.Type, i.Weight, i.Ticket.TicketNo);
                    }
                    break;
            }
            Console.Read();


        }
    }
}
