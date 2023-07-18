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
            cmd.Parameters.AddWithValue("@ordID", om.orgID);
            cmd.Parameters.AddWithValue("@orgName", om.orgName);
            cmd.Parameters.AddWithValue("@orgType", om.orgType);
            cmd.Parameters.AddWithValue("@orgAddress", om.orgAddress);
            cmd.Parameters.AddWithValue("@orgCapacity", om.orgCapacity);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static async Task<List<OrganizationModel>> GetOrganizations()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetOrganization", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<OrganizationModel> orgs = new List<OrganizationModel>();
            while (await reader.ReadAsync())
            {
                OrganizationModel model = new OrganizationModel();
                model.orgID = Guid.Parse(reader["ordID"].ToString());
                model.orgName = reader["orgName"].ToString();
                model.orgType = reader["orgType"].ToString();
                model.orgAddress = reader["orgAddress"].ToString();
                model.orgCapacity = int.Parse(reader["orgCapacity"].ToString());
                orgs.Add(model);
            }
           await con.CloseAsync();
            return orgs;
        }
        public static int DeleteOrganization(int id)
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
