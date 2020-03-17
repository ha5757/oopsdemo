using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace oopsdemo
{
   public class DBHandler
    {

       public static SqlConnection GetConnection()
        {
            string str = ConfigurationManager.ConnectionStrings["SqlCon"].ToString();
            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
           // return new SqlConnection(str);
        }
    }
}
