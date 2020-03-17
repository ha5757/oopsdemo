using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
  public  class TicketBooking
    {
        public SqlConnection SqlCon
        {
            get{ return DBHandler.GetConnection(); }
        }
        public void AddTicket(TicketDetail detail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TicketBooking values(@pi, @pn, @td, @dt, @tc)",SqlCon);
                cmd.Parameters.AddWithValue("@pi", detail.PassengerId);
                cmd.Parameters.AddWithValue("@pn", detail.PassengerName);
                cmd.Parameters.AddWithValue("@td", detail.TravelDate);
                cmd.Parameters.AddWithValue("@dt", detail.DistanceTravel);
                CalculateCost(detail);
                cmd.Parameters.AddWithValue("@tc", detail.TicketCost);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CalculateCost(TicketDetail detail)
        {
            if (detail.DistanceTravel <= 100)
                detail.TicketCost = detail.DistanceTravel * 1;
            else if (detail.DistanceTravel > 100 && detail.DistanceTravel <= 300)
                detail.TicketCost = detail.DistanceTravel*1.5;
            else if (detail.DistanceTravel > 300 && detail.DistanceTravel <= 500)
                detail.TicketCost = detail.DistanceTravel* 2.5;
            else
                detail.TicketCost = detail.DistanceTravel - 500* 4.5;
        }

    }
}
