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
        public static async Task<List<CustomerWorkInfo>> GetCustomerWorkInfos()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetWorkInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<CustomerWorkInfo> workInfos = new List<CustomerWorkInfo>();
            while (await reader.ReadAsync())
            {
                CustomerWorkInfo workInfo = new CustomerWorkInfo();
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
