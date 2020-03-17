using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock13
{
    class maint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the contacts:");
            int n = int.Parse(Console.ReadLine());
            List<Contact> l1 = new List<Contact>();
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();
                String[] s1 = s.Split(',');
                Contact c=new Contact(s1[0],s1[1],s1[2],s1[3],s1[4],s1[5],DateTime.ParseExact(s1[6], "dd-MM-yyyy", CultureInfo.InvariantCulture));
                l1.Add(c);
                //l1.Add(Contact.CreateContact(s));
            }
            SortedDictionary<String, int> d = Contact.GetContactCountForDomain(l1);
            Console.WriteLine("{0} {1,20}", "Domain Name", "Count");
            ICollection<String> I = d.Keys;
            foreach(string key in I)
            {
                Console.WriteLine("{0} {1,20}", key, d[key]);
            }
            Console.Read();
        }
    }
}
