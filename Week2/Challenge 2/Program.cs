using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Challenge_2.BL;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int count = 0;
            Login[] users = new Login[size];
            Read(users, ref count);
            Login added = new Login();
            Login S = new Login();

            while (true)
            {
                char op = Menu();
                if (op == '1')
                {
                    bool f;
                    Console.WriteLine("Enter Your name: ");
                    S.name = Console.ReadLine();
                    Console.WriteLine("Enter Your Password: ");
                    S.pass = Console.ReadLine();
                    f = Sign_In(users, S, count);
                    if (f == true)
                    {
                        Console.WriteLine("Welcome " + S.name);
                    }
                    else
                    {
                        Console.WriteLine("Record not Found!!");
                    }
                }
                else if (op == '2')
                {
                    Console.WriteLine("Enter Your name: ");
                    added.name = Console.ReadLine();
                    Console.WriteLine("Enter Your Password: ");
                    added.pass = Console.ReadLine();
                    users[count] = added;
                    Sign_Up(users[count]);
                    count++;

                }
                else if (op == '3')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You Entered Wrong Input!!");
                }
                Console.WriteLine("Enter any character to continue!");
                Console.ReadKey();
                Console.Clear();
            }

        }
        static bool Sign_In(Login[] u, Login n, int s)
        {
            for (int i = 0; i < s; i++)
            {
                if (u[i].name == n.name && u[i].pass == n.pass)
                {
                    return true;
                }
            }
            return false;
        }
        static void Read(Login[] u, ref int count)
        {
            string path = "D:\\Semester2\\OOPs\\Week2\\Challenge 2\\Files\\Stored.txt";
            StreamReader R = new StreamReader(path);
            string record;
            while ((record = R.ReadLine()) != null)
            {
                Login n = new Login();
                n.name = ParseRecord(record, 1);
                n.pass = ParseRecord(record, 2);
                u[count] = n;
                count++;
            }
            R.Close();
        }
        static void Sign_Up(Login u)
        {
            string path = "D:\\Semester2\\OOPs\\Week2\\Challenge 2\\Files\\Stored.txt";
            StreamWriter S = new StreamWriter(path, true);
            S.Write("\n" + u.name + "," + u.pass);
            S.Flush();
            S.Close();
        }
        static string ParseRecord(string line, int field)
        {
            string record = "";
            int comma = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    record = record + line[i];
                }
            }
            return record;
        }
        static char Menu()
        {
            Console.WriteLine("Press1 to Sign-In");
            Console.WriteLine("Press2 to Sign-Up");
            Console.WriteLine("Press3 to Exit");
            char op;
            op = char.Parse(Console.ReadLine());
            return op;
        }
    }
}
