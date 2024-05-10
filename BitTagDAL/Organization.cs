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
        public static async Task<List<OrganizationModel>> GetOrganizationsByID(Guid id)
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetOrganizationById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ordID", id);
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
    }
}
