using Microsoft.AspNetCore.Mvc;
using BitTagDAL;
using BitTagModels;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace BitTagAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class OrganizationController : Controller
    {
        [HttpGet]
        [Route("GetOrganizationbyid/{id}")]
        public async Task<JsonResult> GetOrganizationsByID(Guid id)
        {

            List<OrganizationModel> organizations = new List<OrganizationModel>();
            organizations = await Organization.GetOrganizationsByID(id);
            return new JsonResult(organizations);
        }

        [HttpPost]
        [Route("AddOrganization")]
        public async void AddOrganization(OrganizationModel om)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter ("@ordID", om.orgID),
            new SqlParameter("@orgName", om.orgName),
            new SqlParameter("@orgType", om.orgType),
            new SqlParameter("@orgAddress", om.orgAddress),
            new SqlParameter("@orgCapacity", om.orgCapacity)
            };
            await DalCrud.CRUD("Sp_AddOrg", parameters);
            //Organization.CreateOrg(organization);
        }

        [HttpGet]
        [Route("GetOrganizations")]
        public async Task<JsonResult> GetOrganizations()
        {

            List<OrganizationModel> organizations = new List<OrganizationModel>();
            organizations = await Organization.GetOrganizations();
            return new JsonResult(organizations);
        }

        
        [HttpDelete]
        [Route("DeleteOrganization/{id}")]
        public async void DeleteOrganization(Guid id)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter ("@ordID", id)
            };
            await DalCrud.CRUD("Sp_DeleteOrg", parameters);
            //Organization.CreateOrg(organization);
        }
    }
}
