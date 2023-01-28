using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck_System.BL
{
    class FireChief : FireFighter
    {
        public FireChief(string name) : base(name)
        {

        }

        public void DelegateResponsibility(string FirefighterName)
        {
            Console.WriteLine("Tell " + FirefighterName + " to Extinguish Fire");
        }
    }
}
