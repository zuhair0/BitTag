using BitTagModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class VehiclesDAL
    {
        public static async Task<List<VehicleModel>> GetVehicles()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetVehicle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<VehicleModel> vehiclesList = new List<VehicleModel>();
            while (await reader.ReadAsync())
            {
                VehicleModel vehicle = new VehicleModel();
                vehicle.custID_FK = Guid.Parse(reader["custID_FK"].ToString());
                vehicle.tagID = Guid.Parse(reader["tagID"].ToString());
                vehicle.vehiclePlate = reader["vehiclePlate"].ToString();
                vehicle.vehicleMake = reader["vehicleMake"].ToString();
                vehicle.vehicleModel = int.Parse(reader["vehicleModel"].ToString());
                vehicle.vehicleType = reader["vehicleType"].ToString();
                vehicle.vehicleColor = reader["vehicleColor"].ToString();
                vehiclesList.Add(vehicle);
            }
            await con.CloseAsync();
            return vehiclesList;
        }
    }
}
