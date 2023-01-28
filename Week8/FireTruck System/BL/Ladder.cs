using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck_System.BL
{
    class Ladder
    {
        public Ladder(int length, string color)
        {
            this.length = length;
            this.color = color;
        }
        private int length;
        private string color;
        public int GetLength()
        {
            return length;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
    }
}
