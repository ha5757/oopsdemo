using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class VehicleBO
    {
        public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, string type)
        {
            List<Vehicle> L = new List<Vehicle>();
            foreach (var v in vehicleList)
            {
                if (v.Type == type)
                    L.Add(v);

            }
           
                return L;
        }
        public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, DateTime parkedTime)
        {
            List<Vehicle> L1 = new List<Vehicle>();
            foreach(var x in vehicleList)
            {
                if(x.Ticket.ParkedTime==parkedTime)
                {
                    L1.Add(x);
                }
            }
            return L1;
        }
    }
}
