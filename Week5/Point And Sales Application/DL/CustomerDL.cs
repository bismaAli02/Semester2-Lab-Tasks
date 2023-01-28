using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Sales_Application.BL;

namespace Point_And_Sales_Application.DL
{
    class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();




        public static Customer FindCustomer(MUser user)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].name == user.Name && customers[i].pass == user.Pass)
                {
                    return customers[i];
                }
            }
            return null;
        }
        public static void AddCustInList(Customer cust)
        {
            customers.Add(cust);
        }
    }
}
