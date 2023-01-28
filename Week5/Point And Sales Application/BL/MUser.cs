using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Sales_Application.DL;

namespace Point_And_Sales_Application.BL
{
    class MUser
    {
        public MUser()
        {

        }
        public MUser(string Name, string Pass, string Role)
        {
            this.Name = Name;
            this.Pass = Pass;
            this.Role = Role;
            if (Role == "Customer")
            {
                Customer cust = new Customer(Name, Pass);
                CustomerDL.AddCustInList(cust);
            }
        }
        public MUser(string Name, string Pass)
        {
            this.Name = Name;
            this.Pass = Pass;
            this.Role = "NA";
        }
        public string Name;
        public string Pass;
        public string Role;


    }
}
