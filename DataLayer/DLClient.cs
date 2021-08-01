using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DLClient
    {
        private DLConexion connection = new DLConexion();
        SqlDataReader read;
        DataTable table = new DataTable();
     
        public DataTable showClients()
        {
 
            SqlCommand sql = new SqlCommand("SHOW_CLIENTS", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            read = sql.ExecuteReader();
            table.Load(read);
            connection.closeConnection();
            return table;
        }

        public void addClient(string name, string lastName, string gender, int age, string phone, string address, string identificationCard)
        {
            SqlCommand sql = new SqlCommand("SP_INSERT_CLIENT", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@NAME", name);
            sql.Parameters.AddWithValue("@LAST_NAME", lastName);
            sql.Parameters.AddWithValue("@GENDER", gender);
            sql.Parameters.AddWithValue("@AGE", age);
            sql.Parameters.AddWithValue("@PHONE", phone);
            sql.Parameters.AddWithValue("@IDENTIFICATION_CARD", identificationCard);
            sql.Parameters.AddWithValue("@ADDRESS", address);
            sql.Parameters.AddWithValue("@CREATION_DATE", "");
            sql.ExecuteNonQuery();

            sql.Parameters.Clear();
            connection.closeConnection();
        }

        public void editClient(int id, string name, string lastName, string gender, int age, string phone, string address, string identificationCard)
        {
            SqlCommand sql = new SqlCommand("SP_UPDATE_CLIENT", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID_CLIENT", id);
            sql.Parameters.AddWithValue("@NAME", name);
            sql.Parameters.AddWithValue("@LAST_NAME", lastName);
            sql.Parameters.AddWithValue("@GENDER", gender);
            sql.Parameters.AddWithValue("@AGE", age);
            sql.Parameters.AddWithValue("@PHONE", phone);
            sql.Parameters.AddWithValue("@IDENTIFICATION_CARD", identificationCard);
            sql.Parameters.AddWithValue("@ADDRESS", address);
            sql.ExecuteNonQuery();

            sql.Parameters.Clear();
            connection.closeConnection();

        }

        public void deleteClient(int id)
        {
            SqlCommand sql = new SqlCommand("SP_DELETE_CLIENT", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID_CLIENT", id);

            sql.ExecuteNonQuery();

            sql.Parameters.Clear();
            connection.closeConnection();
        }
    }

}
