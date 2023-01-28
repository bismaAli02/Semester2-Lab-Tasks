using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static float Area(float s)
        {
            return s * s;
        }
        static void Main(string[] args)
        {
            float side,area;
            Console.WriteLine("Enter the length of square: ");
            side = float.Parse(Console.ReadLine());
            area=Area(side);
            Console.WriteLine("the area is " + area);
            Console.Read();
        }
    }
}
