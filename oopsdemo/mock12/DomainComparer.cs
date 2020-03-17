using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock12
{
    class DomainComparer : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            String[] s = x.Email.Split('@');
            int pos = s[1].IndexOf('.');
            string s1 = s[1].Substring(0, pos);
            String[] s2 = y.Email.Split('@');
            int pos1 = s2[1].IndexOf('.');
            string s3 = s[1].Substring(0, pos1);
            if (s1.CompareTo(s2) > 0)
                return 1;
            else if (s1.CompareTo(s2) < 0)
                return -1;
            else
                return 0;
        }
    }
}
