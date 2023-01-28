using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_SignUp.BL
{
    class MUserBL
    {
        private string username;
        private string password;
        private string role;

        public MUserBL(string username, string password, string role)
        {
            this.password = password;
            this.role = role;
            this.username = username;
        }

        public MUserBL(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }
        public string getRole()
        {
            return this.role;
        }
    }
}
