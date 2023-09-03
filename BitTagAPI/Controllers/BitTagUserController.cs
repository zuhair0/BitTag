using BitTagDAL;
using BitTagModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class BitTagUserController : Controller
    {
        [HttpPost]
        [Route("SaveBitTagUser")]
        public async void SaveBitTagUser(BitTagUserModel bum)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@userid_fk",bum.userid_fk),
                new SqlParameter("@vehid_fk",bum.vehid_fk),
                new SqlParameter("@bittagcode",bum.bittagcode)
            };
            await DalCrud.CRUD("Sp_SaveBitTagUser", parameters);
        }

    }
}
