using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Einstien", 55000, 24, 300);
            Console.WriteLine("Enter number of chapters you want to include: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter chapter number " + i + 1 + " : ");
                string chp;
                chp = Console.ReadLine();
                b.AddChapter(chp);
            }
            Console.WriteLine("the price of book is: " + b.getPrice());
            Console.WriteLine("the bookmark is at page num: " + b.getBookmark());


            Console.ReadLine();
        }
    }
}
