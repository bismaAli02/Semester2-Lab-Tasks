using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void task_1()
        {
            string path = "D:\\Semester2\\OOPs\\Week1\\Manual3\\Task1\\file.txt";
            if(File.Exists(path))
            {
                StreamReader V = new StreamReader(path);
                int record;
                while((record=V.Read())!=-1)
                {
                    char c = (char)record;
                    if(record!=10&&record!=32&&c!='\n')
                    {
                        Console.WriteLine(c);
                    }
                    
                }
                V.Close();
            }
            else
            {
                Console.WriteLine("File doesn\'t exists!!");
            }
        }
        static void WriteTask2()
        {
            string path = "D:\\Semester2\\OOPs\\Week1\\Manual3\\Task1\\file1.txt";
            StreamWriter x = new StreamWriter(path, true);
            x.WriteLine("hello");
            x.Flush();
            x.Close();
        }
        static void Main(string[] args)
        {
            task_1();
            //WriteTask2();
            Console.Read();
        }
    }
}
