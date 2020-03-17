using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oopsdemo.mockk
{
    class mainact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of bills to be added");
            int n = int.Parse(Console.ReadLine());
            string number;
            string name;
            int units;
            ElectricityBill[] ebill = new ElectricityBill[n];
            BillValidator bvalidate = new BillValidator();
            ElectricityBoard eboard = new ElectricityBoard();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                ebill[i] = new ElectricityBill();
                try
                {
                    Console.WriteLine("Enter Consumer Number:");
                    number = Console.ReadLine();

                    string p = @"^[E][B][0-9]{5}$";
                    Regex r = new Regex(p);
                    if (r.IsMatch(number))
                    {
                        ebill[i].ConsumerNumber = number;
                        Console.WriteLine("Enter Consumer Name:");
                        name = Console.ReadLine();

                        ebill[i].ConsumerName = name;
                        Console.WriteLine("Enter Units Consumed:");
                        units = int.Parse(Console.ReadLine());
                        while (bvalidate.ValidateUnitsConsumed(units) != null)
                        {
                            Console.WriteLine(bvalidate.ValidateUnitsConsumed(units));
                            Console.WriteLine("Enter Units Consumed:");
                            units = int.Parse(Console.ReadLine());
                        }

                        ebill[i].UnitsConsumed = units;

                        //Console.WriteLine(ebill[i].ConsumerNumber);
                        eboard.AddBill(ebill[i]);
                    }

                    else

                        throw new FormatException("Invalid Consumer Number");
                

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                

            }
            Console.WriteLine();


            Console.WriteLine("Enter Last 'N' Number of Bills To Generate");
            int num = int.Parse(Console.ReadLine());
            List<ElectricityBill> list = eboard.Generate_N_BillDetails(num);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ebill[i].ConsumerNumber +"\n" +ebill[i].ConsumerName
                    +"\n" +ebill[i].UnitsConsumed +"\n" +ebill[i].BillAmount);
                Console.WriteLine();
            }
            Console.WriteLine("Details of last ‘N’ bills:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("EB bill for " + list[i].ConsumerName + " is " + list[i].BillAmount);
            }
            Console.Read();
        }
    }
}
