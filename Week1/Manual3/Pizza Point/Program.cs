using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Pizza_Point
{
    class Program
    {
        static void Input(ref int order,ref int price)
        {
            Console.Write("Enter no. of orders: ");
            order = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum price: ");
            price= int.Parse(Console.ReadLine());
        }
        static string ParseRecord(string line, int field)
        {
            string record = "";
            int comma = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ','||line[i]==32)
                {
                    comma++;
                }
                else if (comma == field)
                {
                    if(line[i]!='['&&line[i]!=']')
                    {
                        record = record + line[i];
                    }
                }
            }
            return record;
        }
        static void PizzaPoints(int MinPrice,int P,ref int count)
        {
            if (P <= MinPrice)
            {
                count++;
            }
        }
        static void readData(int P_r,int order)
        {
            int[] minPrice=new int[100];
            int minOrder,count=0;
            string name;
            int P = P_r;
            string path = "D:\\Semester2\\OOPs\\Week1\\Manual3\\Pizza Point\\Costumer.txt";
            if(File.Exists(path))
            {
                StreamReader R = new StreamReader(path);
                string record;
                while((record=R.ReadLine())!=null)
                {
                    count = 0;
                    name = ParseRecord(record, 1);
                    minOrder = int.Parse(ParseRecord(record, 2));
                    int idx = 0;
                    for(int i=3; i<=minOrder+2;i++)
                    {
                        minPrice[idx] = int.Parse(ParseRecord(record, i));
                        int min = minPrice[idx];
                        PizzaPoints(min, P, ref count);
                        idx++;
                    }
                    if (count >= order)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int order=0, P=0;
            Input(ref order,ref P);
            //Console.Write(price + " " + order);
            readData(P,order);
            Console.Read();
        }
    }
}
