using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Sales_Application.BL;

namespace Point_And_Sales_Application.DL
{
    class MUserDL
    {
        public static List<MUser> UsersList = new List<MUser>();




        public static void AddInList(MUser user)
        {
            UsersList.Add(user);
        }
        public static MUser IsUserAvailable(MUser user)
        {
            for (int i = 0; i < UsersList.Count; i++)
            {
                if (user.Name == UsersList[i].Name && user.Pass == UsersList[i].Pass)
                {
                    return UsersList[i];
                }
            }
            return null;
        }
    }
}
