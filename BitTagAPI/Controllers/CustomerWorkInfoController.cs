﻿using BitTagDAL;
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
        public async void AddWorkInfo(CustomerWorkInfo cwi)
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
            List<CustomerWorkInfo> workInfos = new List<CustomerWorkInfo>();
            workInfos = await CustomerWorkInfoDAL.GetCustomerWorkInfos();
            return new JsonResult(workInfos);
        }
    }
}
