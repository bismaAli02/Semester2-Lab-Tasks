using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck_System.BL
{
    class HosePipe
    {
        public HosePipe(string material, string shape, float diameter, float waterFlowRate)
        {
            this.diameter = diameter;
            this.material = material;
            this.shape = shape;
            this.waterFlowRate = waterFlowRate;
        }
        private float diameter;
        private float waterFlowRate;
        private string material;
        private string shape;
    }
}
