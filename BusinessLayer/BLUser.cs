using System;
using System.Collections.Generic;
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

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public void signUp()
        {
            SHA256 sha256Hash = SHA256.Create();
            string hash = dlHash.GetHash(sha256Hash, password);

            userObject.signUp(username, email, hash);
        }
    }
}
