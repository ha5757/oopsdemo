using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock10
{
    class Group
    {
        string _name;
        List<Contact> _contactList;

        public string Name { get => _name; set => _name = value; }
        internal List<Contact> ContactList { get => _contactList; set => _contactList = value; }

        public Group(string name, List<Contact> contactList)
        {
            Name = name;
            ContactList = contactList;
        }

        public void AddContactToGroup(Contact contact)
        {
            _contactList.Add(contact);
        }
        public bool RemoveContactFromGroup(string name)
        {

            foreach (var v in _contactList)
            {
                if (v.Name == name)
                {
                    _contactList.Remove(v);
                    return true;
                }     
            }
            return false;
        }
        public void DisplayContacts()
        {
            if (_contactList.Count == 0)
            {
                Console.WriteLine("No contact to show");

            }
            else
                Console.WriteLine("Contacts in" + _name);
            Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
            foreach(var v in ContactList)
            {
                //Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", v.Name, v.Company, v.Title, v.Mobile, v.AlternateMobile, v.Email, v.DateCreated);
                Console.WriteLine(v);
            }
        }

    }
}
