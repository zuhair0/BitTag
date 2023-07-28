using BitTagDAL;
using BitTagModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class OrgnizationEmployeesController : Controller
    {
        [HttpPost]
        [Route("AddOrgEmployee")]
        public async void AddOrgEmployee(Orgnization_EmployeeModel oem)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@orgID_FK",oem.orgID_FK),
                new SqlParameter("@Emp_ID",oem.Emp_ID),
                new SqlParameter("@Emp_firstName",oem.Emp_firstName),
                new SqlParameter("@Emp_lastName",oem.Emp_lastName),
                new SqlParameter("@Emp_CNIC",oem.Emp_CNIC),
                new SqlParameter("@Pin",oem.Pin),
                new SqlParameter("@Designation",oem.Designation),
                new SqlParameter("@PhoneNum",oem.PhoneNum)
            };
            await DalCrud.CRUD("Sp_AddOrgEmployee", parameters);
        }
        [HttpGet]
        [Route("GetOrgEmployees")]
        public async Task<JsonResult> GetOrgEmployees()
        {
            List<Orgnization_EmployeeModel> employees = new List<Orgnization_EmployeeModel>();
            employees = await OrganiztionEmployees.GetOrgEmployees();
            if(employees.Count > 0)
            {
                return new JsonResult(employees);
            }
            else
            {
                return new JsonResult("Not Found");
            }
        }
        [HttpDelete]
        [Route("DeleteOrgEmployee/{id}")]
        public async void DeleteOrgEmployee(Guid id)
        {
            SqlParameter[] parameters=
            {
                new SqlParameter("@Emp_ID",id)
            };
            await DalCrud.CRUD("Sp_DeleteEmployee", parameters);
        }

    }
}
