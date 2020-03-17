using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mock12
{
    class DateComparer : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            if(x.DateCreated>y.DateCreated)
            {
                return 1;
            }
            else if(x.DateCreated<y.DateCreated)
             {
                return -1;
             }
            else
            {
                return 0;
            }
        }
    }
}
