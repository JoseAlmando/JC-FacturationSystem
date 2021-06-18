

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DataLayer
{
    public class DLUsers
    {
     
        private DLConexion connection = new DLConexion();

        public void signUp(string username, string email, string password)
        {
            SqlCommand sql = new SqlCommand("sp_signup", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@username", username);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", password);
            sql.ExecuteNonQuery();
            connection.closeConnection();
        }

    }
}
