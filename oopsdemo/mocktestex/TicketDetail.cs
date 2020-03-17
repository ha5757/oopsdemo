using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
  public  class TicketDetail
    {
        string passengerId;
        string passengerName;
        string travelDate;
        int distanceTravel;
        double ticketCost;

        public string PassengerId { get => passengerId; set => passengerId = value; }
        public string PassengerName { get => passengerName; set => passengerName = value; }
        public string TravelDate { get => travelDate; set => travelDate = value; }
        public int DistanceTravel { get => distanceTravel; set => distanceTravel = value; }
        public double TicketCost { get => ticketCost; set => ticketCost = value; }
    }
}
