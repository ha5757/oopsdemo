using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock9
{
    class ContactBO
    {
        public List<Contact> FindContact(List<Contact> contactList, List<string> name)
        {
            List<Contact> c = new List<Contact>();
            foreach (var s in name)
            {
                foreach (var v in contactList)
                {
                    if(s==v.Name)
                    {
                        c.Add(v);
                    }
                }
            }
            return c;
        }
        public List<Contact> FindContact(List<Contact> contactList, DateTime dateCreated)
        {
            List<Contact> L = new List<Contact>();
           
                foreach(var x in contactList)
                {
                    if(x.DateCreated==dateCreated)
                {
                    L.Add(x);
                }
                }
            return L;
            
        }
        public List<Contact> FindContact(List<Contact> contactList, string domain)
        {
            List<Contact> L1 = new List<Contact>();
            foreach(var t in contactList)
            {
                string[] s1 = t.Email.Split('@');
                int pos = s1[1].IndexOf('.');
                string s = s1[1].Substring(0, pos);
                if(s==domain)
                {
                    L1.Add(t);
                }
               
            }
            return L1;
        }
    }
}
