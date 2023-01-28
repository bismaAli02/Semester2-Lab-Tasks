using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SignIn_SignUp
{
    class Program
    {
        static string ParseRecord(string line,int field)
        {
            string record="";
            int comma = 1;
            for(int i=0;i<line.Length;i++)
            {
                if(line[i]==',')
                {
                    comma++;
                }
                else if(comma==field)
                {
                    record = record + line[i];
                }
            }
            return record;
        }
        static bool Sign_In(string name,string pass)
        {
            bool found = false;
            string n, p;
            string path = "D:\\Semester2\\OOPs\\Week1\\Manual3\\SignIn-SignUp\\Stored.txt";
            if(File.Exists(path))
            {
                StreamReader R = new StreamReader(path);
                string record;
                while((record=R.ReadLine())!=null)
                {
                    n = ParseRecord(record, 1);
                    p = ParseRecord(record, 2);
                    if(n==name&&p==pass)
                    {
                        found = true;
                        break;
                    }
                }
                R.Close();

            }
            else
            {
                Console.WriteLine("Not Exists!!");
            }
            return found;
        }
        static void Sign_Up(string name,string pass)
        {
            string path = "D:\\Semester2\\OOPs\\Week1\\Manual3\\SignIn-SignUp\\Stored.txt";
            StreamWriter S = new StreamWriter(path, true);
            S.WriteLine(name + "," + pass);
            S.Flush();
            S.Close();
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
        static void Main(string[] args)
        {
            string n, pass;
            char op;
            while(true)
            {
                op = Menu();
                if(op=='1')
                {
                    bool f = false;
                    Console.WriteLine("Enter Your name: ");
                    n = Console.ReadLine();
                    Console.WriteLine("Enter Your Password: ");
                    pass = Console.ReadLine();
                    f=Sign_In(n, pass);
                    if(f==true)
                    {
                        Console.WriteLine("Welcome "+ n);
                    }
                    else
                    {
                        Console.WriteLine("Record not Found!!");
                    }
                }
                else if(op=='2')
                {
                    Console.WriteLine("Enter Your name: ");
                    n=Console.ReadLine();
                    Console.WriteLine("Enter Your Password: ");
                    pass = Console.ReadLine();
                    Sign_Up(n, pass);

                }
                else if(op=='3')
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
            //Console.Read();
        }
    }
}
