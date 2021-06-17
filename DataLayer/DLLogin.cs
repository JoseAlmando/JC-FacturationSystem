﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DataLayer
{
    public class DLLogin
    {
        DLHash dlHash = new DLHash();
        private DLConexion connection = new DLConexion();

        public DataTable signIn(string email, string password)
        {
            SHA256 sha256Hash = SHA256.Create();
            string hash = dlHash.GetHash(sha256Hash, password);

            SqlDataReader data;
            DataTable dataTable = new DataTable();
            SqlCommand sql = new SqlCommand("sp_signin", connection.openConnection());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", hash);
            sql.ExecuteNonQuery();
            data = sql.ExecuteReader();

            dataTable.Load(data);

            return dataTable;
        }
    }
}
