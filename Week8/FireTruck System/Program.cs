using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireTruck_System.BL;

namespace FireTruck_System
{
    class Program
    {
        static void Main(string[] args)
        {
            HosePipe h = new HosePipe("plastic", "circular", 12F, 10F);
            FireChief f = new FireChief("Ahmad");
            FireTruck t = new FireTruck(h, f);
            f.DelegateResponsibility("Ali");
            f.Drive();
            Console.ReadKey();
        }
    }
}
