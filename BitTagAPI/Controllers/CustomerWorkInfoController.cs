using BitTagDAL;
using BitTagModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class CustomerWorkInfoController : Controller
    {
        [HttpPost]
        [Route("AddWorkInfo")]
        public async void AddWorkInfo(CustomerWorkInfoModel cwi)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@org_FK",cwi.org_FK),
                new SqlParameter("@userID_FK",cwi.userID_FK),
                new SqlParameter("@WorkType",cwi.WorkType),
                new SqlParameter("@Desig",cwi.Desig),
                new SqlParameter("@worktime",cwi.worktime),
            };
            await DalCrud.CRUD("Sp_SaveWorkInfo", parameters);
        }
        [HttpGet]
        [Route("GetCustWorkInfo")]
        public async Task<JsonResult> GetCustWorkInfo()
        {
            List<CustomerWorkInfoModel> workInfos = new List<CustomerWorkInfoModel>();
            workInfos = await CustomerWorkInfoDAL.GetCustomerWorkInfos();
            return new JsonResult(workInfos);
        }
        [HttpGet]
        [Route("GetCustWorkInfoByID/{id}")]
        public async Task<JsonResult> GetCustWorkInfoByID(string id)
        {
            List<CustomerWorkInfoModel> workInfos = new List<CustomerWorkInfoModel>();
            workInfos = await CustomerWorkInfoDAL.GetCustomerWorkInfoByID(id);
            return new JsonResult(workInfos);
        }
        [HttpDelete]
        [Route("DeleteWorkInfo/{id}")]
        public async void DeleteCustWorkInfo(Guid id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@userID_FK",id)
            };
            await DalCrud.CRUD("Sp_DeleteCustWorkInfo", parameters);
        }
    }
}
