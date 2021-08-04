using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BLUser
    {
        DLUsers userObject = new DLUsers();
        DLHash dlHash = new DLHash();

        private String email;
        private String password;
        private String username;
        private String cedula;
        SHA256 sha256Hash = SHA256.Create();

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public void signUp()
        {
            string hash = dlHash.GetHash(sha256Hash, password);

            userObject.signUp(username, email, hash, cedula);
        }

        public DataTable findEmail()
        {
            DataTable user;
            user = userObject.findEmail(email);
            return user;
        }

        public void UpdatePassword()
        {
            string hash = dlHash.GetHash(sha256Hash, password);
            userObject.UpdatePassword(email, hash);

        }
    }
}
