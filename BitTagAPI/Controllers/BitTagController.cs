using BitTagDAL;
using BitTagModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class BitTagController : Controller
    {
        public async void AddBitTagDetails(BitTagDetailsModel btd)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@tagID",btd.tagID),
                new SqlParameter("@tagSerial",btd.tagSerial),
                new SqlParameter("@custID_FK",btd.custID_FK),
                new SqlParameter("@orgId",btd.orgId)
            };
            await DalCrud.CRUD("Sp_BitTagDetils", parameters);
        }
    }
}
