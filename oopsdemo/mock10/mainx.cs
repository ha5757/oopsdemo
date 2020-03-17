using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock10
{
    class mainx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the group name:");
            string s = Console.ReadLine();
            Group g = new Group(s, new List<Contact>());
            //Contact n = new Contact();
            while (true)
            {
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Delete Contact");
                Console.WriteLine("3.Display contacts");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the number of contacts:");
                        int c = int.Parse(Console.ReadLine());
                        for (int i = 0; i < c; i++)
                        {
                            String v = Console.ReadLine();
                            Contact p=Contact.CreateContact(v);
                            g.AddContactToGroup(p);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the contact to be deleted:");
                        string Q = Console.ReadLine();

                        if (g.RemoveContactFromGroup(Q))
                        {
                            Console.WriteLine("Contact successfully deleted");
                        }
                        else
                            Console.WriteLine("Contact not found in the group");
                        
                        break;
                    case 3:
                        g.DisplayContacts();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;



                }
            }
            Console.Read();
        }
    }
}
