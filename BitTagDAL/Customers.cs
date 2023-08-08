using BitTagModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class Customers
    {
        public static async Task<List<CustomersModel>> GetCustomers()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<CustomersModel> customers = new List<CustomersModel>();
            while(await reader.ReadAsync())
            {
                CustomersModel customersModel = new CustomersModel();
                customersModel.custID = Guid.Parse(reader["custID"].ToString());
                customersModel.firstName = reader["firstName"].ToString();
                customersModel.lastName = reader["lastName"].ToString();
                customersModel.custCNIC = reader["custCNIC"].ToString();
                customersModel.custEmail = reader["custEmail"].ToString();
                customersModel.contact = reader["contact"].ToString();
                customersModel.DOB =DateTime.Parse(reader["DOB"].ToString());
                customersModel.custPIN =int.Parse(reader["custPIN"].ToString());
                customers.Add(customersModel);
            }
            await con.CloseAsync();
            return customers;
        }
    }
}
