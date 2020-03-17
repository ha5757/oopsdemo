using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock12
{
    class NameComparer : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            if (x.Name.CompareTo(y.Name) > 0)
                return 1;
            else if (x.Name.CompareTo(y.Name) < 0)
                return -1;
            else
                return 0;
                
        }
    }
}
