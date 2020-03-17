using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock5
{
    class parkedTimeComparer : IComparer<Vehicle>
    {
        
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.Ticket.ParkedTime > y.Ticket.ParkedTime)
                return 1;
            else if (x.Ticket.ParkedTime < y.Ticket.ParkedTime)
                return -1;
            else
                return 0;
        }
    }
}
