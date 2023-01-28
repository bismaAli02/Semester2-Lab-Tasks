using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck_System.BL
{
    class FireTruck
    {
        public FireTruck(HosePipe hosePipe, FireFighter driver)
        {
            this.ladder = new Ladder(34, "Black");
            this.hosePipe = hosePipe;
            this.driver = driver;
        }
        private Ladder ladder;
        private HosePipe hosePipe;
        private FireFighter driver;
    }
}
