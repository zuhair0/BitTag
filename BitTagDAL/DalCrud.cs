using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class DalCrud
    {
        public static async Task CRUD(string ProcedureName, SqlParameter[] sqlParameters)
        {
			try
			{
				using (SqlConnection con = DBhelper.GetConnection())
				{
					await con.OpenAsync();
					using (SqlCommand cmd = new SqlCommand(ProcedureName, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddRange(sqlParameters);
						await cmd.ExecuteNonQueryAsync();

					}
					await con.CloseAsync();
				}

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

        }
    }
}
