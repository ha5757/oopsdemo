using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Ticket
    {
        string _ticketNo;
        DateTime _parkedTime;
        Double _cost;

        public Ticket()
        {
        }

        public Ticket(string ticketNo, DateTime parkedTime, double cost)
        {
            TicketNo = ticketNo;
            ParkedTime = parkedTime;
            Cost = cost;
        }

        public string TicketNo { get => _ticketNo; set => _ticketNo = value; }
        public DateTime ParkedTime { get => _parkedTime; set => _parkedTime = value; }
        public double Cost { get => _cost; set => _cost = value; }
    }
}
