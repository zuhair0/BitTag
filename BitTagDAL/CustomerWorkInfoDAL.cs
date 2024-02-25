using BitTagModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class CustomerWorkInfoDAL
    {
        public static async Task<List<CustomerWorkInfoModel>> GetCustomerWorkInfos()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetWorkInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<CustomerWorkInfoModel> workInfos = new List<CustomerWorkInfoModel>();
            while (await reader.ReadAsync())
            {
                CustomerWorkInfoModel workInfo = new CustomerWorkInfoModel();
                workInfo.org_FK = Guid.Parse(reader["org_FK"].ToString());
                workInfo.userID_FK = Guid.Parse(reader["userID_FK"].ToString());
                workInfo.WorkType = reader["WorkType"].ToString();
                workInfo.Desig = reader["Desig"].ToString();
                workInfo.worktime = DateTime.Parse(reader["worktime"].ToString());
                workInfos.Add(workInfo);
            }
            await con.CloseAsync();
            return workInfos;
        }
        public static async Task<List<CustomerWorkInfoModel>> GetCustomerWorkInfoByID(string id)
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_getWorkinfoByID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custCNIC", id);
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<CustomerWorkInfoModel> workInfos = new List<CustomerWorkInfoModel>();
            while (await reader.ReadAsync())
            {
                CustomerWorkInfoModel workInfo = new CustomerWorkInfoModel();
                workInfo.org_FK = Guid.Parse(reader["org_FK"].ToString());
                workInfo.userID_FK = Guid.Parse(reader["userID_FK"].ToString());
                workInfo.WorkType = reader["WorkType"].ToString();
                workInfo.Desig = reader["Desig"].ToString();
                workInfo.worktime = DateTime.Parse(reader["worktime"].ToString());
                workInfos.Add(workInfo);
            }
            await con.CloseAsync();
            return workInfos;
        }
    }
}
