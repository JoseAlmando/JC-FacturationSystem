using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
namespace BusinessLayer
{

    public class BLLogIn
    {
        DLLogin userObject = new DLLogin();

        private String email;
        private String password;

        public string Email { get => email; set => email= value; }
        public string Password { get => password; set => password = value; }

        public DataTable sigIn()
        {
            DataTable user;
            user = userObject.signIn(email, password);
            return user;
        }
       
    }
}
