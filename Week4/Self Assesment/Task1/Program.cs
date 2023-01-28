using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("umair", 207, 0, 250, 1000, "Lahore", true);
            Console.WriteLine(s.isEligibleforScholarship(80));
            Student s1 = new Student("umair", 207, 0, 250, 1000, "Lahore", false);
            Console.WriteLine(s1.isEligibleforScholarship(80));
            Console.ReadLine();
        }
    }
}
