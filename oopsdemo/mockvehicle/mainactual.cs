using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.mockvehicle
{
    class mainactual
    {
        static void Main(string[] args)
        {
            VehicleDetails detail = new VehicleDetails();
            Vehicle_Validator vd = new Vehicle_Validator();
            VehicleRegister vr = new VehicleRegister();
            Console.WriteLine("enter choice 1.adddetails 2.display details");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1: 
                        Console.WriteLine("Enter Vehicle Details");
                        Console.WriteLine("Enter VehicleNo");
                        String vnum= Console.ReadLine();
                        
                        while(vd.ValidateVehicle(vnum)!=null)
                    {
                        Console.WriteLine(vd.ValidateVehicle(vnum));
                        Console.WriteLine("Enter VehicleNo");
                        vnum = Console.ReadLine();
                    }
                        detail.VehicleNo = vnum;
                        Console.WriteLine("Enter Brand");
                        String bnd = Console.ReadLine();
                         detail.Brand = bnd;
                    Console.WriteLine("Enter Date of Manufacture");
                    DateTime dof = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    detail.DateofManufacture = dof;
                    Console.WriteLine("Enter Date of Registration");
                    DateTime dor= DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    detail.DateofRegistration = dor;
                    Console.WriteLine("Enter VehicleType:");
                    string vet = Console.ReadLine();
                    detail.VehicleType = vet;
                    Console.WriteLine("Enter Vehicle Buyer:");
                    String vbuyer = Console.ReadLine();
                    detail.VehicleBuyer = vbuyer;
                    Console.WriteLine("Vehicle Cost");
                    int co = int.Parse(Console.ReadLine());
                    detail.Cost = co;
                    Console.WriteLine("Confirm the details Y/N?");
                    String n = Console.ReadLine();
                    if (n == "Y")
                    {
                        vr.AddVehicle(detail);
                        Console.WriteLine("Enter VehicleNo:" + detail.VehicleNo);

                        Console.WriteLine("Enter Brand:\t"+ detail.Brand);
                        Console.WriteLine("Enter Date of Manufacture:\t" + detail.DateofManufacture.ToString("dd-MMM-yyyy"));
                        Console.WriteLine("Enter Date of Registration:" + detail.DateofRegistration.ToString("dd-MMM-yyyy"));
                        Console.WriteLine("Enter VehicleType:" + detail.VehicleType);
                        Console.WriteLine("Enter Vehicle Buyer:" + detail.VehicleBuyer);
                        Console.WriteLine("Vehicle Cost" + detail.Cost);
                        Console.WriteLine("Registration Cost"+detail.Registrationcost);
                        
                        int age = (int)(detail.DateofRegistration.Subtract(detail.DateofManufacture).TotalDays / 365);
                        if (age < 15)
                            Console.WriteLine("Vehicle life"+age);
                        
                        
                    }
                    else
                        System.Environment.Exit(0);
                    break;

                case 2:
                    Console.WriteLine("enter startdate and enddate");
                    DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    List<VehicleDetails> l1 = vr.DisplayDetails(startDate, endDate);
                    for(int i=0;i<l1.Count;i++)
                    {
                        Console.WriteLine(l1[i].VehicleNo + "" + l1[i].Brand + "" + l1[i].DateofManufacture.ToString("dd-MMM-yyyy") + " " + l1[i].DateofRegistration.ToString("dd-MMM-yyyy")+ " " + l1[i].VehicleType + " " + l1[i].VehicleBuyer + " " + l1[i].Cost + " " + l1[i].Registrationcost);
                    }
                    break;

            }
            Console.Read();
        }
        
    }
}
