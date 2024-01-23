using System.Data.SqlClient;
using BitTagDAL;
namespace BitTagUser.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;
        
        public UserAccountService()
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetAuth", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            _users= new List<UserAccount>();
            while (dr.Read())
            {
                UserAccount _user = new UserAccount();
                _user.Cnic = dr["custCNIC"].ToString();
                _user.Pin = int.Parse(dr["custPin"].ToString());
                _user.Role = "Administrator";
                _users.Add(_user);
            }
            con.Close();
        }

        public UserAccount? GetByUserName(string Cnic)
        {
            return _users.FirstOrDefault(x => x.Cnic == Cnic);
        }
    }
}
