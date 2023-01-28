using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BL;

namespace Task3
{
    class Program
    {
        static char Menu()
        {
            Console.WriteLine("Press1 to add products");
            Console.WriteLine("Press2 to add Customer");
            Console.WriteLine("Press3 to buy product");
            Console.WriteLine("Press4 to view all purchased product");
            Console.WriteLine("Press5 to view all tax of all purchased product");
            Console.WriteLine("Press6 to EXIT");
            char op = char.Parse(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            List<Customer> customer = new List<Customer>();
            while (true)
            {
                Console.Clear();
                char op = Menu();
                if (op == '1')
                {
                    string name, category;
                    int price;
                    Console.WriteLine("Enter name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter category: ");
                    category = Console.ReadLine();
                    Console.WriteLine("Enter price: ");
                    price = int.Parse(Console.ReadLine());
                    Product p = new Product(name, category, price);
                    product.Add(p);
                }
                else if (op == '2')
                {
                    string name, address, number;
                    Console.WriteLine("Enter name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter address: ");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter number: ");
                    number = Console.ReadLine();
                    Customer c = new Customer(name, address, number);
                    customer.Add(c);
                }
                else if (op == '3')
                {
                    int idx;
                    if (customer.Count != 0)
                    {
                        Console.WriteLine("Enter which customer wants to login: ");
                        idx = int.Parse(Console.ReadLine());
                        for (int i = 0; i < product.Count; i++)
                        {
                            product[i].viewP();
                            Console.WriteLine("Press Y to buy Product");
                            char y = char.Parse(Console.ReadLine());
                            if (y == 'y' || y == 'Y')
                            {
                                customer[idx].product.Add(product[i]);
                            }
                        }
                    }
                }
                else if (op == '4')
                {

                    int idx;
                    if (customer.Count != 0)
                    {
                        Console.WriteLine("Enter which customer wants to login: ");
                        idx = int.Parse(Console.ReadLine());
                        customer[idx].getAllProduct();
                    }
                }
                else if (op == '5')
                {

                    int idx;
                    if (customer.Count != 0)
                    {
                        Console.WriteLine("Enter which customer wants to login: ");
                        idx = int.Parse(Console.ReadLine());
                        customer[idx].AllTax();
                    }
                }
                else if (op == '6')
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
