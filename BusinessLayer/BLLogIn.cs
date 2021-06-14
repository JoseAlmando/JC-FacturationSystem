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
        DLUsers userObject = new DLUsers();

        private String email;
        private String password;

        public string Email { get => email; set => email= value; }
        public string Password { get => password; set => password = value; }

        public SqlDataReader sigIn()
        {
            SqlDataReader user;
            user = userObject.signIn(email, password);

            return user;
        }
        public void signUp()
        {
            userObject.signUp(email, password) ;
        }
    }
}
