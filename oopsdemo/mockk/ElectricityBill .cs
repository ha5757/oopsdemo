using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mockk
{
   public class ElectricityBill
    {
        String consumerNumber;
        String consumerName;
        int unitsConsumed;
         double billAmount;

        
        public string ConsumerNumber { get => consumerNumber; set => consumerNumber = value; }
        public string ConsumerName { get => consumerName; set => consumerName = value; }
        public int UnitsConsumed { get => unitsConsumed; set => unitsConsumed = value; }
        public double BillAmount { get => billAmount; set => billAmount = value; }
    }
}
