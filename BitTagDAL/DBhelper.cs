using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class DBhelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Server=tcp:bittagfyp.database.windows.net,1433;Initial Catalog=BitTagFYP;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";");
            return con;
        }
    }
}
