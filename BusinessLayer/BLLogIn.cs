using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using System.Security.Cryptography;

namespace BusinessLayer
{

    public class BLLogIn
    {
        DLLogin userObject = new DLLogin();
        DLHash dlHash = new DLHash();

        private String email;
        private String password;

        public string Email { get => email; set => email= value; }
        public string Password { get => password; set => password = value; }

        public DataTable sigIn()
        {
            SHA256 sha256Hash = SHA256.Create();
            string hash = dlHash.GetHash(sha256Hash, password);

            DataTable user;
            user = userObject.signIn(email, hash);
            return user;
        }
       
    }
}
