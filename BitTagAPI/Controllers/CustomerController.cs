using BitTagDAL;
using BitTagModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [Route("api/controleer")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpPost]
        [Route("AddCustomer")]
        public async void AddCustomer(CustomersModel cm)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@custID",cm.custID),
                new SqlParameter("@firstName",cm.firstName),
                new SqlParameter("@lastName",cm.lastName),
                new SqlParameter("@custCNIC",cm.custCNIC),
                new SqlParameter("@custEmail",cm.custEmail),
                new SqlParameter("@contact",cm.contact),
                new SqlParameter("@DOB",cm.DOB),
                new SqlParameter("@custPIN",cm.custPIN),
            };
            await DalCrud.CRUD("Sp_AddCustomer", parameters);
        }
        [HttpGet]
        [Route("GetCustomer")]
        public async Task<JsonResult> GetCustomer()
        {

        }
    }
}
