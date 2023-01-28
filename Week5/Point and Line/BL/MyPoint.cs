using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_and_Line.BL
{
    class MyPoint
    {
        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;

        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetXY(int x, int y)
        {
            SetX(x);
            SetY(y);
        }
        public double DistanceWithCords(int x, int y)
        {
            double distance;
            distance = Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2);
            distance = Math.Sqrt(distance);
            return distance;
        }
        public double DistanceWithObject(MyPoint point)
        {
            double distance;
            //distance = Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2);
            //distance = Math.Sqrt(distance);
            distance = DistanceWithCords(point.x, point.y);
            return distance;
        }
        public double DistanceFromZero()
        {
            double distance;
            //distance = Math.Pow(this.x - 0, 2) + Math.Pow(this.y - 0, 2);
            //distance = Math.Sqrt(distance);
            distance = DistanceWithCords(0, 0);
            return distance;
        }
    }
}
