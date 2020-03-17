using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mocktestex
{
    class maina
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Ticket Details");
            TicketDetail detail = null;
            TicketBooking tb = new TicketBooking();
            DistanceValidator dv = new DistanceValidator();
            List<TicketDetail> l = new List<TicketDetail>();
            while (true)
            {
                detail = new TicketDetail();
                Console.WriteLine("Enter Passenger Id");
                string a = Console.ReadLine();
                detail.PassengerId = a;
                Console.WriteLine("Enter Passenger Name");
                string b = Console.ReadLine();
                detail.PassengerName = b;
                Console.WriteLine("Enter Travel Date");
                string c = Console.ReadLine();
                detail.TravelDate = c;
                Console.WriteLine("Enter Distance Travelled");
                int d = int.Parse(Console.ReadLine());
                while (dv.ValidateTravelDistance(d) != null)
                {
                    Console.WriteLine(dv.ValidateTravelDistance(d));
                    Console.WriteLine("Enter Distance Travelled:");
                    d = int.Parse(Console.ReadLine());
                }
                detail.DistanceTravel = d;
                tb.AddTicket(detail);
                l.Add(detail);

                Console.WriteLine("Book Another Ticket:(y/n)");
                //string ch = Console.ReadLine();
                char ch = Console.ReadLine()[0];
                if (ch == 'y')
                    continue;
                else
                    break;
            }
            
            foreach (var v in l)
            {
                Console.WriteLine(v.PassengerId + "\n" + v.PassengerName + "\n"
                    + v.TravelDate + "\n" + v.DistanceTravel + "\n" +"ticket cost="+ v.TicketCost);
            }
            Console.Read();
        }
    }
}
