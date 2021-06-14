using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DLLogin
    {
        private DLConexion connection = new DLConexion();

        public SqlDataReader signIn(string email, string password)
        {
            SqlDataReader data;
            SqlCommand sql = new SqlCommand("sp_signup", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", password);
            sql.ExecuteNonQuery();
            connection.closeConnection();

            data = sql.ExecuteReader();
            return data;
        }
    }
}
