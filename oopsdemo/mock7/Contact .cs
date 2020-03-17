﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock7
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

        public override string ToString()
        {
            string str = null;
            str = "\nName:" + _name;
            str = str + "\nCompany:" + _company;
            str = str + "\nTitle:" + _title;
            str = str + "\nMobile:" + _mobile;
            str = str + "\nAlternateMobile:" + _alternateMobile;
            str = str + "\nEmail:" + _email;
            str = str + "\nDateCreated:" + _dateCreated.ToString("dd-MM-yyyy");
            return str;
        }
        public override bool Equals(object obj)
        {
            Contact c = (Contact)obj;
            if (c._name.ToUpper() == _name.ToUpper() && c._mobile.ToUpper() == _mobile.ToUpper() && c._email.ToUpper() == _email.ToUpper())
                return true;
            else
                return false;

        }
    }
}
