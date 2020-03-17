using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock12
{
    class mainh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the contacts:");
            int n = int.Parse(Console.ReadLine());
            List<Contact> l1 = new List<Contact>();
            for(int i=0;i<n;i++)
            {
                String s = Console.ReadLine();
                l1.Add(Contact.CreateContact(s));
            }
           
            Console.WriteLine("Enter a type to sort:");
            Console.WriteLine("1.Sort by name");
            Console.WriteLine("2.Sort by email domain");
            Console.WriteLine("3.Sort by date created");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    NameComparer n1 = new NameComparer();
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    l1.Sort(n1);
                    foreach(var v in l1)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", v.Name, v.Company, v.Title, v.Mobile, v.AlternateMobile, v.Email, v.DateCreated);
                    }
                    break;
                case 2:
                    DomainComparer c1 = new DomainComparer();
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    l1.Sort(c1);
                    foreach (var v1 in l1)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", v1.Name, v1.Company, v1.Title, v1.Mobile, v1.AlternateMobile, v1.Email, v1.DateCreated);
                    }
                    break;
                case 3:
                    DateComparer dc = new DateComparer();
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    l1.Sort(dc);
                    foreach (var v2 in l1)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", v2.Name, v2.Company, v2.Title, v2.Mobile,v2.AlternateMobile, v2.Email, v2.DateCreated);
                    }
                    break;
            }
            Console.Read();
        }
    }
}
