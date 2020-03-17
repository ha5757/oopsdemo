using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
  public  class DistanceValidator
    {
        public String ValidateTravelDistance(int TravelDistance)
        {
            if (TravelDistance < 0)
            {
                return "Given distance is invalid";
            }
            else
                return null;
        }
    }
}
