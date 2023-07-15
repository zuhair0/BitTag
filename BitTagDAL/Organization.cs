using BitTagModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class Organization
    {
        public static int CreateOrg(OrganizationModel om)
        {
            SqlConnection con=DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddOrg", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orgName", om.orgName);
            cmd.Parameters.AddWithValue("@orgType", om.orgType);
            cmd.Parameters.AddWithValue("@orgAddress", om.orgAddress);
            cmd.Parameters.AddWithValue("@orgCapacity", om.orgCapacity);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
