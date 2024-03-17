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
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-PO81H2P\\DELL;Initial Catalog=BitTag;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9QE7L0;Initial Catalog=BitTag;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Server=tcp:bittagserver.database.windows.net,1433;Initial Catalog=BitTaag;Persist Security Info=False;User ID=sqladmin;Password=Office343@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-REC0NDU\\SAMEERSQL;Initial Catalog=BitTag;TrustServerCertificate=true;Integrated Security=True");
            return con;
        }
    }
}
