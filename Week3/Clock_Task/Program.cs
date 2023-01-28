using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clock_Task.BL;

namespace Clock_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock empty = new Clock();
            Console.WriteLine("Empty Clock Declared: ");
            empty.Print();


            Clock full = new Clock(8, 10, 10);
            Console.WriteLine("Full Clock: ");
            full.Print();

            full.Inc_Sec();
            full.Print();
            full.Inc_Min();
            full.Print();
            full.Inc_H();
            full.Print();
            full.isEqual(8, 10, 11);
            full.isEqual(empty);


            Console.WriteLine(full.Elapsed());
            Console.WriteLine(full.Remaining());

            Clock c1 = new Clock(12, 13, 32);
            Clock c2 = new Clock(2, 10, 3);
            full.Diff(c1, c2);
            full.Print();

            Console.ReadLine();
        }
    }
}
