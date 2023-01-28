using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Task.BL
{
    class Clock
    {
        public Clock()
        {
            hours = 0;
            min = 0;
            sec = 0;
        }
        public Clock(int h)
        {
            hours = h;
            min = 0;
            sec = 0;
        }
        public Clock(int h, int m)
        {
            hours = h;
            min = m;
            sec = 0;
        }
        public Clock(int h, int m, int s)
        {
            hours = h;
            min = m;
            sec = s;
        }
        public int hours;
        public int min;
        public int sec;

        public void Inc_Sec()
        {
            Console.Write("Time with Seconds Increased: ");
            sec++;
        }
        public void Inc_Min()
        {
            Console.Write("Time with Minutes Increased: ");
            min++;
        }
        public void Inc_H()
        {
            Console.Write("Time with hours Increased: ");
            hours++;
        }
        public void Print()
        {
            Console.WriteLine(hours + " : " + min + " : " + sec);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && m == min && s == sec)
            {
                Console.WriteLine("Is Equal");
                return true;
            }
            Console.WriteLine("Not Equal");
            return false;
        }
        public bool isEqual(Clock c)
        {
            if (hours == c.hours && c.min == min && c.sec == sec)
            {
                Console.WriteLine("Is Equal");
                return true;
            }
            Console.WriteLine("Not Equal");
            return false;
        }
        public int Elapsed()
        {
            int time;
            time = (hours * 60 * 60) + (min * 60) + sec;
            return time;
        }
        public int Remaining()
        {
            int time;
            int total = 86400;
            time = Elapsed();
            time = total - time;
            return time;
        }
        public void Diff(Clock c1, Clock c2)
        {
            int t1, t2, diff;
            t1 = c1.Elapsed();
            t2 = c2.Elapsed();
            if (t1 > t2)
            {
                diff = t1 - t2;
            }
            else
            {
                diff = t2 - t1;
            }
            sec = diff % 60;
            diff = diff / 60;
            min = diff % 60;
            diff = diff / 60;
            hours = diff;

        }
    }
}
