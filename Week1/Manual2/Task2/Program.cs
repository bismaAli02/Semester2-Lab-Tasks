using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Conditional1()
        {
            float marks;
            Console.WriteLine("Enter your Marks: ");
            marks = float.Parse(Console.ReadLine());
            if(marks>50)
            {
                Console.WriteLine("You passed!!");
            }
            else
            {
                Console.WriteLine("You Failed!!");
            }
        }
        static void Loop1()
        {
            for(int x=0; x<5;x++)
            {
                Console.WriteLine("Welcome");
            }
        }
        static void CondLoop1()
        {
            int num,sum=0;
            Console.WriteLine("Enter any number: ");
            num=int.Parse(Console.ReadLine());
            while(num!=-1)
            {
                Console.WriteLine("Enter any number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("The sum is: " + sum);
        }
        static void CondLoop2()
        {
            int num, sum = 0;
            do
            {
                Console.WriteLine("Enter any number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            } while (num != -1);
            Console.WriteLine("The sum is: " + sum);

        }
        static void ArrTask()
        {
            int[] n = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter number: ");
                n[i] = int.Parse(Console.ReadLine());
            }
            int largest = n[0];
            for(int i=0;i<3;i++)
            {
                if(largest<n[i])
                {
                    largest = n[i];
                }
            }
            Console.WriteLine(largest);
        }
        static void Calculate(int age,double P,int T)
        {
            int i = 1;
            double Price=0;
            int x = 10;
            bool Afford = false;
            while(i<=age)
            {
                if(i%2==0)
                {
                    Price = Price + x;
                    x = x + 10;
                    Price--;
                }
                if(i%2!=0)
                {
                    Price = Price + T;
                }
                i++;
            }
            if (Price>P)
            {
                Console.WriteLine("Yes!! " + (Price - P));
            }
            else
            {
                Console.WriteLine("No!! " + (P - Price));
            }
        }
        static void TakeAwayTask()
        {
            int age,toyP;
            double price;
            Console.WriteLine("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of washing Machine: ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price per toy: ");
            toyP = int.Parse(Console.ReadLine());
            Calculate(age, price, toyP);
        }
        static void Main(string[] args)
        {
            //Conditional1();
            //Loop1();
            //CondLoop1();
            //CondLoop2();
            //ArrTask();
            TakeAwayTask();
            Console.Read();
        }
    }
}
