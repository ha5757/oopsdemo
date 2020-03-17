using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock6
{
    class Vehicle
    {
        string _registrationNo;
        string _name;
        string _type;
        double _weight;

        public Vehicle()
        {
        }

        public Vehicle(string registrationNo, string name, string type, double weight)
        {
            RegistrationNo = registrationNo;
            Name = name;
            Type = type;
            Weight = weight;
        }

        public string RegistrationNo { get => _registrationNo; set => _registrationNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public double Weight { get => _weight; set => _weight = value; }

        public static Vehicle CreateVehicle(string detail)
        {
            //List<Vehicle> L = new List<Vehicle>();
            string[] s = detail.Split(',');
            Vehicle v = new Vehicle(s[0], s[1], s[2],double.Parse(s[3]));
            return v;
            

        }
        public static SortedDictionary<string, int>TypeWiseCount(List<Vehicle> vehicleList)
        {
            int tw = 0, fw = 0;
            //List<Vehicle> L = new List<Vehicle>();
            foreach (var v in vehicleList)
            {
                if (v.Type == "TwoWheeler")
                    tw++;
                else
                    fw++;

            }

           
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd.Add("FourWheeler", fw);
            sd.Add("TwoWheeler", tw);
            return sd;
        }
}
}
