using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck_System.BL
{
    class FireFighter
    {
        public FireFighter()
        {

        }
        public FireFighter(string name)
        {
            this.name = name;
        }
        protected string name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void Drive()
        {
            Console.WriteLine(name + " is Driving The Truck");
        }
        public void ExtenguishFire()
        {
            Console.WriteLine(name + " is Extenguishing Fire");
        }
    }
}
