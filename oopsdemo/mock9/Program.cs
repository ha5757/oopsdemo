using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of contact details:");
            int v = int.Parse(Console.ReadLine());
            List<Contact> n = new List<Contact>();
            ContactBO cb = new ContactBO();
            for (int i = 0; i < v; i++)
            {
                String p = Console.ReadLine();
                String[] t = p.Split(',');
                Contact c = new Contact(t[0], t[1], t[2], t[3], t[4], t[5], DateTime.ParseExact(t[6],"dd-MM-yyyy",CultureInfo.InvariantCulture));
                n.Add(c);
            }
            Console.WriteLine("Enter a search type:");
            Console.WriteLine("1.Name");
            Console.WriteLine("2.Date created");
            Console.WriteLine("3.Email domain");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the names:");
                    String P = Console.ReadLine();
                    string[] x = P.Split(',');
                    List<string> b = new List<string>();
                    foreach(var c in x)
                    {

                        b.Add(c);
                    }
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    List<Contact> Lp = cb.FindContact(n, b);
                    foreach(var q in Lp)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", q.Name, q.Company, q.Title, q.Mobile, q.AlternateMobile, q.Email, q.DateCreated);
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Enter the date to search contacts that were created on that date ");
                    string St = Console.ReadLine();
                    DateTime D = DateTime.ParseExact(St, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    List<Contact> vp = cb.FindContact(n, D);
                    foreach(var g in vp)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", g.Name, g.Company, g.Title, g.Mobile, g.AlternateMobile, g.Email, g.DateCreated);
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the Email domain to search contacts that have same email domain ");
                    String vd = Console.ReadLine();
                    List<Contact> tp = cb.FindContact(n, vd);
                    foreach(var z in tp)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", z.Name, z.Company, z.Title, z.Mobile, z.AlternateMobile, z.Email, z.DateCreated);
                    }
                    break;


            }
            Console.Read();
        }
    }
}
