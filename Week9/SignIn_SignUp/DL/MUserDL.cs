using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SignIn_SignUp.BL;

namespace SignIn_SignUp.DL
{
    class MUserDL
    {
        public static List<MUserBL> Users = new List<BL.MUserBL>();

        public static void readData()
        {
            string username, password, role;
            string record;
            string path = "users.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while ((record = file.ReadLine()) != null)
                {
                    username = parseData(record, 1);
                    password = parseData(record, 2);
                    role = parseData(record, 3);
                    BL.MUserBL user = new BL.MUserBL(username, password, role);
                    Users.Add(user);
                }
                file.Close();
            }
        }

        public static void writeData()
        {
            string path = "users.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < Users.Count; i++)
            {
                if (i > 0)
                {
                    file.WriteLine();
                }
                file.Write("{0},{1},{2}", Users[i].getUsername(), Users[i].getPassword(), Users[i].getRole());
            }
            file.Flush();
            file.Close();
        }

        public static string parseData(string data, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + data[i];
                }
            }
            return item;
        }

        public static string checkData(MUserBL user)
        {
            string role = "NONE";
            for (int i = 0; i < Users.Count; i++)
            {
                if (user.getUsername() == Users[i].getUsername() && user.getPassword() == Users[i].getPassword())
                {
                    role = Users[i].getRole();
                }
            }
            return role;
        }
    }
}
