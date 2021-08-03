

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

        public void signUp(string username, string email, string password, string cedula)
        {
            SqlCommand sql = new SqlCommand("sp_signup", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@username", username);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", password);
            sql.Parameters.AddWithValue("@cedula", cedula);
            sql.ExecuteNonQuery();
            connection.closeConnection();
        }

        public DataTable findEmail(string email)
        {
            SqlDataReader data;
            DataTable dataTable = new DataTable();
            SqlCommand sql = new SqlCommand("SP_FIND_EMAIL", connection.openConnection());

            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@email", email);
            sql.ExecuteNonQuery();
            data = sql.ExecuteReader();

            dataTable.Load(data);
            return dataTable;
        }

    }
}
