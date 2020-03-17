using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mockk
{
   public class BillValidator
    {
        public String ValidateUnitsConsumed(int UnitsConsumed)
        {
            if (UnitsConsumed < 0)
            {
                return "Given units is invalid";
            }
            else
                return null;

        }
    }
}
