using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock13
{
    class Contact
    {
        string _name;
        string _company;
        string _title;
        string _mobile;
        string _alternateMobile;
        string _email;
        DateTime _dateCreated;

        public Contact()
        {
        }

        public Contact(string name, string company, string title, string mobile, string alternateMobile, string email, DateTime dateCreated)
        {
            Name = name;
            Company = company;
            Title = title;
            Mobile = mobile;
            AlternateMobile = alternateMobile;
            Email = email;
            DateCreated = dateCreated;
        }

        public string Name { get => _name; set => _name = value; }
        public string Company { get => _company; set => _company = value; }
        public string Title { get => _title; set => _title = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string AlternateMobile { get => _alternateMobile; set => _alternateMobile = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }
        public static SortedDictionary<string, int> GetContactCountForDomain(List<Contact> list)
        {
            
            int ap = 0, intel = 0, ib = 0, micro = 0; 
            foreach(Contact item in list)
            {
                String[] s = item.Email.Split('@');
                int pos = s[1].IndexOf('.');
                string s2 = s[1].Substring(0, pos);
                if (s2 == "apple")
                     ap++;
                else if (s2 == "intel")
                    intel++;
                else if (s2 == "ibm")
                    ib++;
                else if(s2=="micro")
                    micro++;
            }
            SortedDictionary<string, int> t = new SortedDictionary<string, int>();
            t.Add("apple", ap);
            t.Add("ibm", ib);
            t.Add("intel", intel);
            t.Add("micro", micro);
            return t;
        }
    }
}
