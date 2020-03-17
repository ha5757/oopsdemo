using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock6
{
    class maincl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of vehicles");
            int x = int.Parse(Console.ReadLine());
            List<Vehicle> L = new List<Vehicle>();
            for (int i = 0; i < x; i++)
            {
                string p = Console.ReadLine();
        
                L.Add(Vehicle.CreateVehicle(p));
            }

            Console.Write("{0,-15} {1}\n", "Type", "No. of Vehicles");
            SortedDictionary<string, int> s = Vehicle.TypeWiseCount(L);
            Console.WriteLine(s.Count);
            ICollection<String> I = s.Keys;
            foreach(string key in I)
            {
                Console.Write("{0,-15} {1}\n",key,key[ValueTuple]);
            }
        }
    }
}
