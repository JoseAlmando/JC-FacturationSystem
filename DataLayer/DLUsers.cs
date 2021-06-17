

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
        DLHash dlHash = new DLHash();
        private DLConexion connection = new DLConexion();

        public void signUp(string username, string email, string password)
        {
            
            SHA256 sha256Hash = SHA256.Create();
            string hash = dlHash.GetHash(sha256Hash, password);

            SqlCommand sql = new SqlCommand("sp_signup", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@username", username);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", hash);
            sql.ExecuteNonQuery();
            connection.closeConnection();
        }

    }
}
