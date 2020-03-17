using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oopsdemo.mockvehicle
{
    class Vehicle_Validator
    {
        public String ValidateVehicle(string VehicleNo)
        {
            string s1 = "^[A-Z]{2}[0-9]{1,2}\\s[A-Z]{2}\\s[0-9]{4}$";
            Regex R = new Regex(s1);
            if(R.IsMatch(VehicleNo))
            {
                return null;
            }
            else
            {
                return "Given Vehicle no  is invalid";
            }
        }
    }
}
