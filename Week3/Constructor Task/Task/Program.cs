using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BL;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ahmad", 0, 10, 1);
            Console.WriteLine(s1.name);
            Student s2 = new Student("Umair", 0, 10, 1);
            Console.WriteLine(s2.name);
            Student s3 = new Student("Ali", 0, 10, 1);
            Console.WriteLine(s3.name);
            Console.ReadKey();
        }
    }
}
