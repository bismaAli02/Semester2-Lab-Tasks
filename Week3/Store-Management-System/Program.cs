using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Management_System.BL;

namespace Store_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            while (true)
            {
                Console.Clear();
                char op = Menu();
                if (op == '1')
                {
                    Product p = new Product();
                    p.Input();
                    products.Add(p);
                }
                else if (op == '2')
                {
                    Console.WriteLine("Name\tCategory\tPrice\tStock");
                    for (int i = 0; i < products.Count; i++)
                    {
                        products[i].Display();
                    }
                }
                else if (op == '3')
                {
                    int idx = products[0].Highest(products);
                    Console.WriteLine("Product with Highest Price is: " + products[idx].name + " and price is " + products[idx].price);
                }
                else if (op == '4')
                {
                    Console.WriteLine("Name\t\tTax");
                    for (int i = 0; i < products.Count; i++)
                    {
                        products[i].TaxDisplay();
                    }
                }
                else if (op == '5')
                {
                    Console.WriteLine("Name\t\tStock");
                    for (int i = 0; i < products.Count; i++)
                    {
                        products[i].Ordred();
                    }
                }
                else if (op == '6')
                {
                    break;
                }
                Console.ReadKey();
            }
        }

        static char Menu()
        {
            char op;
            Console.WriteLine("Press1 to add product");
            Console.WriteLine("Press2 to View All Products");
            Console.WriteLine("Press3 to Find Product with Highest Price");
            Console.WriteLine("Press4 to View Sales Tax of All Products");
            Console.WriteLine("Press5 to see which Products needed to be ordered");
            Console.WriteLine("Press6 to Exit");
            op = Console.ReadLine()[0];
            return op;
        }
    }
}
