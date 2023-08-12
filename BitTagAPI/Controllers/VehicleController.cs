using BitTagDAL;
using BitTagModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BitTagAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class VehicleController : Controller
    {
        [HttpPost]
        [Route("AddVehicle")]
        public async void AddVehicle(VehicleModel vm)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@custID_FK",vm.custID_FK),
                new SqlParameter("@tagID",vm.tagID),
                new SqlParameter("@vehiclePlate",vm.vehiclePlate),
                new SqlParameter("@vehicleMake",vm.vehicleMake),
                new SqlParameter("@vehicleModel",vm.vehicleModel),
                new SqlParameter("@vehicleType",vm.vehicleType),
                new SqlParameter("@vehicleColor",vm.vehicleColor)
            };
            await DalCrud.CRUD("Sp_AddVehicle", parameters);
        }
        [HttpGet]
        [Route("GetVehicle")]
        public async Task<JsonResult> GetVehicles()
        {
            List<VehicleModel> vehiclesList = new List<VehicleModel>();
            vehiclesList =await VehiclesDAL.GetVehicles();
            return new JsonResult(vehiclesList);
            
        }
        [HttpDelete]
        [Route("DeleteVehicle/{id}")]
        public async void DeleteVehicle(string id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@vehiclePlate",id)
            };
            await DalCrud.CRUD("Sp_DeleteVehicle", parameters);
        }
        
    }
}
