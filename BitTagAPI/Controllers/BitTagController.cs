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
        [HttpPost]
        [Route("AddBitTagDetails")]
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
        [HttpGet]
        [Route("GetBitTagDetails")]
        public async Task<JsonResult> GetBitTagDetails()
        {
            List<BitTagDetailsModel> bitTagDetails = new List<BitTagDetailsModel>();
            bitTagDetails = await BitTagDetailsDAL.BitTagDetails();
            return new JsonResult(bitTagDetails);
        }
        [HttpDelete]
        [Route("DeleteBitTagDetails/{id}")]
        public async void DeleteBitTagDetails(Guid id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@tagID",id)
            };
            await DalCrud.CRUD("Sp_DeleteBitTag", parameters);
        }
    }
}
