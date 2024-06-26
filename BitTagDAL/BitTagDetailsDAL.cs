﻿using BitTagModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class BitTagDetailsDAL
    {
        public static async Task<List<BitTagDetailsModel>> BitTagDetails()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetBitTagDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<BitTagDetailsModel> bitTagDetails = new List<BitTagDetailsModel>();
            while(await reader.ReadAsync())
            {
                BitTagDetailsModel bitTag = new BitTagDetailsModel();
                bitTag.tagID = Guid.Parse(reader["tagID"].ToString());
                bitTag.tagSerial = int.Parse(reader["tagSerial"].ToString());
                //bitTag.custID_FK = Guid.Parse(reader["custID_FK"].ToString());
                bitTag.orgId = Guid.Parse(reader["orgId"].ToString());
                bitTagDetails.Add(bitTag);
            }
            await con.CloseAsync();
            return bitTagDetails;
        }
    }
}
