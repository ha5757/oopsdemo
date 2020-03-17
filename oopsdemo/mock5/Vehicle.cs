using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock5
{
    class Vehicle:IComparable<Vehicle>
    {

        string _registrationNo;
        string _name;
        string _type;
        Double _weight;
        Ticket _ticket;

        public Vehicle()
        {
        }

        public Vehicle(string registrationNo, string name, string type, double weight, Ticket ticket)
        {
            RegistrationNo = registrationNo;
            Name = name;
            Type = type;
            Weight = weight;
            Ticket = ticket;
        }

        public string RegistrationNo { get => _registrationNo; set => _registrationNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public Ticket Ticket { get => _ticket; set => _ticket = value; }

        public static Vehicle CreateVehicle(string detail)
        {
            String[] s = detail.Split(',');
            Ticket t = new Ticket(s[4], DateTime.Parse(s[5]), Double.Parse(s[6]));
            Vehicle V = new Vehicle(s[0], s[1], s[2], double.Parse(s[3]), t);
            return V;
        }

        public int CompareTo(Vehicle other)
        {
            if (this.Weight > other.Weight)
                return 1;
            else if (this.Weight < other.Weight)
                return -1;
            else
                return 0;
        }
    }
}
