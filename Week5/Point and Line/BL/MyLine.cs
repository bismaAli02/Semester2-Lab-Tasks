using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_and_Line.BL
{
    class MyLine
    {
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyPoint begin;
        public MyPoint end;

        public MyPoint GetBegin()
        {
            return begin;
        }
        public void SetBegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public MyPoint GetEnd()
        {
            return end;
        }
        public void SetEnd(MyPoint end)
        {
            this.end = end;
        }
        public double GetLength()
        {
            return begin.DistanceWithObject(end);
        }
        public double GetGradient()
        {
            double gradient;
            gradient = (end.y - begin.y) / (end.x - begin.x);
            return gradient;
        }
    }
}
