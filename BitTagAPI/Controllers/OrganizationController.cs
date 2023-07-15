using Microsoft.AspNetCore.Mvc;
using BitTagDAL;
using BitTagModels;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class OrganizationController : Controller
    {
        [HttpPost]
        [Route("AddOrganization")]
        public int CreateOrg(OrganizationModel om)
        {
            SqlConnection con = DBhelper.GetConnection();
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
        //public void AddOrganization()
        //{
        //    OrganizationModel organization = new OrganizationModel();
        //    Organization.CreateOrg(organization);
        //}
    }
}
