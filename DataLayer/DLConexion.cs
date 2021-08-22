using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{

    class DLConexion
    {
        static string stringConnection = $"Server=JOXALM\\SQLEXPRESS;Database=testJC;Trusted_Connection=True;";
        private SqlConnection connection = new SqlConnection(stringConnection);

        public SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            return connection;
        }

        public SqlConnection closeConnection()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
            return connection;
        }
    }
}
