using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace oopsdemo.mockvehicle
{
    class VehicleRegister
    {
        public SqlConnection SqlCon
        {
            get { return DBHandler.GetConnection(); }
        }
        public void AddVehicle(VehicleDetails detail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into VehicleDetails values(@vn,@br,@dm,@dr,@vt,@vb,@c,@rc)", SqlCon);
                cmd.Parameters.AddWithValue("@vn", detail.VehicleNo);
                cmd.Parameters.AddWithValue("@br", detail.Brand);
                cmd.Parameters.AddWithValue("@dm", detail.DateofManufacture);
                cmd.Parameters.AddWithValue("@dr", detail.DateofRegistration);
                cmd.Parameters.AddWithValue("@vt", detail.VehicleType);
                cmd.Parameters.AddWithValue("@vb", detail.VehicleBuyer);
                cmd.Parameters.AddWithValue("@c", detail.Cost);
                CalculateCost(detail);
                cmd.Parameters.AddWithValue("@rc", detail.Registrationcost);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                SqlCon.Close();
            }
        }
        public void CalculateCost(VehicleDetails detail)
        {
            int age = (int)(detail.DateofRegistration.Subtract(detail.DateofManufacture).TotalDays / 365);
   
                if (detail.VehicleType == "2 Wheeler")
                {
                    if (detail.VehicleBuyer == "New")
                    {
                    detail.Registrationcost = 12 * detail.Cost / 100;
                    }
                    else if(detail.VehicleBuyer=="old"&&age<15) 
                    {
                        if(age>=5)
                        {
                        detail.Registrationcost = 8 * detail.Cost / 100;
                        }
                        else if(age>=3&&age<5)
                        {
                        detail.Registrationcost = 9 * detail.Cost / 100;
                        }
                        else
                        {
                        detail.Registrationcost = 10 * detail.Cost / 100;
                        }
                    }
                else
                {
                    Console.WriteLine("Given Vehicle cannot be registered as it is more than  15  year");
                }

            }
                else
                {
                    if (detail.VehicleBuyer == "New")
                    {
                    detail.Registrationcost = 14 * detail.Cost / 100;
                    }
                    else if(age<15&&detail.VehicleBuyer== "Old")
                    {
                    if (age >= 5)
                        detail.Registrationcost = 9 * detail.Cost / 100;
                    else if (age >= 3 && age < 5)
                        detail.Registrationcost = (float)10.5 * detail.Cost / 100;
                    else
                        detail.Registrationcost = (float)12.50 * detail.Cost / 100;
                    }
                    else
                    {
                    Console.WriteLine("Given Vehicle cannot be registered as it is more than  15  year");
                    }

                }
            
        }
       public List<VehicleDetails> DisplayDetails(DateTime startDate, DateTime endDate)
        {
            List<VehicleDetails> l = new List<VehicleDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from VehicleDetails where DateofRegistration between @s and @e", SqlCon);
                cmd.Parameters.AddWithValue("@s", startDate);
                cmd.Parameters.AddWithValue("@e", endDate);
                SqlDataReader R = cmd.ExecuteReader();
                VehicleDetails vc = null;
                while(R.Read())
                {
                    vc = new VehicleDetails();
                    vc.VehicleNo = R[0].ToString();
                    vc.Brand = R[1].ToString();
                    vc.DateofManufacture = DateTime.Parse(R[2].ToString());
                    vc.DateofRegistration = DateTime.Parse(R[3].ToString());
                        vc.VehicleType = R[4].ToString();
                    vc.VehicleBuyer = R[5].ToString();
                    vc.Cost = int.Parse(R[6].ToString());
                    vc.Registrationcost = float.Parse(R[7].ToString());
                    l.Add(vc);
                }

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                SqlCon.Close();
            }
            return l;
        }
    }
}
