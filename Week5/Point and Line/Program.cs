using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_and_Line.BL;

namespace Point_and_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLine Line = null;
            char op;
            while (true)
            {
                op = Menu();

                if (op == '1')
                {
                    Line = TakeLineInput();
                }
                else if (op == '2')
                {
                    UpdatePoint(Line.begin);
                }
                else if (op == '3')
                {
                    UpdatePoint(Line.end);
                }
                else if (op == '4')
                {
                    DisplayPoint(Line.begin);
                }
                else if (op == '5')
                {
                    DisplayPoint(Line.end);
                }
                else if (op == '6')
                {
                    LengthOfLine(Line);
                }
                else if (op == '7')
                {
                    GradientOfLine(Line);
                }
                else if (op == '8')
                {
                    DistanceFromZero(Line.begin);
                }
                else if (op == '9')
                {
                    DistanceFromZero(Line.end);
                }
                else if (op == '0')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT!!");
                }
                ScreenCLS();
            }
            Console.ReadLine();
        }

        static void Header()
        {
            Console.WriteLine("Point And Line Application");
        }
        static char Menu()
        {
            Header();
            Console.WriteLine("Press 1 to Make a Line");
            Console.WriteLine("Press 2 to Update Begin Point");
            Console.WriteLine("Press 3 to Update End Point");
            Console.WriteLine("Press 4 to Show Begin Point");
            Console.WriteLine("Press 5 to Show End Point");
            Console.WriteLine("Press 6 to Get the Length of the Line");
            Console.WriteLine("Press 7 to Get the Gradient of the Line");
            Console.WriteLine("Press 8 to Find the Distance of Begin Point from Zero Coordinates");
            Console.WriteLine("Press 9 to Find the Distance of End Point from Zero Coordinates");
            Console.WriteLine("Press 0 to EXIT");
            char op = char.Parse(Console.ReadLine());
            return op;
        }
        static MyLine TakeLineInput()
        {
            Console.WriteLine("Enter the Beginning Point: ");
            MyPoint begin = TakePointInput();
            Console.WriteLine("Enter the Ending Point: ");
            MyPoint end = TakePointInput();
            MyLine Line = new MyLine(begin, end);
            return Line;
        }
        static MyPoint TakePointInput()
        {
            Console.Write("Enter the X-Coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the Y-Coordinate: ");
            int y = int.Parse(Console.ReadLine());
            MyPoint point = new MyPoint(x, y);
            return point;
        }
        static void UpdatePoint(MyPoint point)
        {
            Console.Write("Enter the X-Coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the Y-Coordinate: ");
            int y = int.Parse(Console.ReadLine());
            point.SetXY(x, y);
        }
        static void DisplayPoint(MyPoint point)
        {
            Console.WriteLine("X-Coordinate is: " + point.GetX());
            Console.WriteLine("Y-Coordinate is: " + point.GetY());
        }
        static void LengthOfLine(MyLine Line)
        {
            Console.WriteLine("The Length of Line is: " + Line.GetLength());
        }
        static void GradientOfLine(MyLine Line)
        {
            Console.WriteLine("The Gradient of Line is: " + Line.GetGradient());
        }
        static void DistanceFromZero(MyPoint point)
        {
            Console.WriteLine("The Distance of the Point from Origin is: " + point.DistanceFromZero());
        }
        static void ScreenCLS()
        {
            Console.WriteLine("Enter any key to Continue!!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
