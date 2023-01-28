using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int ProductEntered = 0;
            Product[] products = new Product[size];
            while (true)
            {
                char op = ' ';
                Console.Clear();
                Menu(ref op);
                if (op == '1')
                {
                    if (ProductEntered <= size)
                    {
                        products[ProductEntered] = AddProduct();
                        ProductEntered++;
                    }
                }
                else if (op == '2')
                {
                    for (int i = 0; i < ProductEntered; i++)
                    {
                        Display(products[i]);
                    }
                }
                else if (op == '3')
                {
                    TotalWorth(products, ProductEntered);
                }
                else if (op == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input!!");
                }
                Console.WriteLine("Enter any key to continue");
                Console.ReadKey();
            }
        }
        static void Display(Product p)
        {
            Console.WriteLine(p.ID + "\t\t" + p.name + "\t\t" + p.Price + "\t\t" + p.category + "\t\t" + p.brand + "\t\t" + p.country);
        }
        static void TotalWorth(Product[] p, int size)
        {
            float w = 0.0F;
            for (int i = 0; i < size; i++)
            {
                w = w + p[i].Price;
            }
            Console.WriteLine("Total Worth of Shop is: {0}", w);
        }
        static Product AddProduct()
        {
            Product p = new Product();
            Console.Write("Enter ID of Product: ");
            p.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter name of Product: ");
            p.name = Console.ReadLine();
            Console.Write("Enter Price: ");
            p.Price = float.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            p.category = Console.ReadLine();
            Console.Write("ENter name of Brand: ");
            p.brand = Console.ReadLine();
            Console.Write("Enter name of country: ");
            p.country = Console.ReadLine();
            return p;
        }
        static void Menu(ref char op)
        {
            Console.WriteLine("Press1 to Add Products");
            Console.WriteLine("Press2 to Show Products");
            Console.WriteLine("Press3 to Get Total Worth of Store");
            Console.WriteLine("Press4 to Exit");
            op = Console.ReadLine()[0];
        }
    }
}
