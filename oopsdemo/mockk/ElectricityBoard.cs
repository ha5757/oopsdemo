using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace oopsdemo.mockk
{
   public class ElectricityBoard
    {

       public SqlConnection SqlCon
        {
            get { return DBHandler.GetConnection(); }
        }
        public void AddBill(ElectricityBill ebill)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into ElectricityBill values(@cno,@cn,@un,@ba)", SqlCon);
               // SqlCon.Open();
                cmd.Parameters.AddWithValue("@cno", ebill.ConsumerNumber);
                cmd.Parameters.AddWithValue("@cn", ebill.ConsumerName);
                cmd.Parameters.AddWithValue("@un", ebill.UnitsConsumed);
                CalculateBill(ebill);
                cmd.Parameters.AddWithValue("@ba",ebill.BillAmount);
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
       public void CalculateBill(ElectricityBill ebill)
        {
            if (ebill.UnitsConsumed <= 100)
            {
                ebill.BillAmount = 0;
            }
            else if (ebill.UnitsConsumed > 100 && ebill.UnitsConsumed <= 300)
            {
                ebill.BillAmount = 100 * 0 + (ebill.UnitsConsumed - 100) * 1.5;
                
            }
            else if (ebill.UnitsConsumed > 300 && ebill.UnitsConsumed <= 600)
            {
                ebill.BillAmount = 100 * 0+ 200 * 1.5 + (ebill.UnitsConsumed - 300) * 3.5;
                
            }
            else if (ebill.UnitsConsumed > 600 && ebill.UnitsConsumed <= 1000)
            {
                ebill.BillAmount = 100 * 0 + 200 * 1.5 + 300 * 3.5 + (ebill.UnitsConsumed - 600) * 5.5;
                
            }
            else
            {
               ebill.BillAmount = 100 * 0+ 200 * 1.5 + 300 * 3.5 + 400 * 5.5 + (ebill.UnitsConsumed - 100) * 7.5;
                
            }
        }
       public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> L = new List<ElectricityBill>();
            try
            {
                SqlCommand cmd = new SqlCommand("select top " + num + " * from ElectricityBill order by Consumer_number desc", SqlCon);
                //SqlCon.Open();
                SqlDataReader R = cmd.ExecuteReader();
                ElectricityBill E = null;
                
                while (R.Read())
                {
                    E = new ElectricityBill();
                    E.ConsumerNumber = R[0].ToString();
                    E.ConsumerName = R[1].ToString();
                    E.UnitsConsumed = int.Parse(R[2].ToString());
                    E.BillAmount = float.Parse(R[3].ToString());
                    L.Add(E);
                }
            }
            catch(SqlException E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                SqlCon.Close();
            }
            return L;
        }
    }
}
