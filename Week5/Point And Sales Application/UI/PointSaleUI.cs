using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Sales_Application.BL;
using Point_And_Sales_Application.DL;

namespace Point_And_Sales_Application.UI
{
    class PointSaleUI
    {
        public static char MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Press1 to Sign-In");
            Console.WriteLine("Press2 to Sign-Up");
            Console.WriteLine("Press3 to Exit");
            char op;
            op = char.Parse(Console.ReadLine());
            return op;
        }
        public static MUser Sign_In()
        {
            string Name, Pass;
            Console.WriteLine("Enter Your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            Pass = Console.ReadLine();
            MUser sign_in = new MUser(Name, Pass);
            return MUserDL.IsUserAvailable(sign_in);

        }
        public static MUser Sign_Up()
        {
            string Name, Pass, Role;
            Console.WriteLine("Enter Your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            Pass = Console.ReadLine();
            Console.WriteLine("Enter Your Roles: ");
            Role = Console.ReadLine();
            MUser user = new MUser(Name, Pass, Role);
            return user;
        }

        public static void AddUserInList(MUser user)
        {
            MUserDL.AddInList(user);
        }
        public static string ParseRecord(string line, int field)
        {
            string record = "";
            int comma = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    record += line[i];
                }
            }
            return record;
        }

        //////////////////Admin Functions Start///////////////
        public static char AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to Add Products");
            Console.WriteLine("Press 2 to View All Products");
            Console.WriteLine("Press 3 to Find Product with Highest Price");
            Console.WriteLine("Press 4 to view Sales Tax of All Products");
            Console.WriteLine("Press 5 to view Products to be Ordered");
            Console.WriteLine("Press 6 to EXIT");
            char op;
            op = char.Parse(Console.ReadLine());
            return op;
        }
        public static Product AddProduct()
        {
            string name, category;
            int price, stock, minStock;
            Console.Write("Enter the name of Product: ");
            name = Console.ReadLine();
            Console.Write("Enter the category of Product: ");
            category = Console.ReadLine();
            Console.Write("Enter the price of Product: ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Enter the Available Stock of Product: ");
            stock = int.Parse(Console.ReadLine());
            Console.Write("Enter the Threshold Stock of Product: ");
            minStock = int.Parse(Console.ReadLine());
            Product product = new Product(name, category, price, stock, minStock);
            return product;
        }
        public static void AddProductInList(Product product)
        {
            ProductDL.AddInList(product);
        }
        public static void ViewAllProducts()
        {
            foreach (var product in ProductDL.products)
            {
                Console.WriteLine("Product name: " + product.name);
                Console.WriteLine("Product Category: " + product.category);
                Console.WriteLine("Product Price: " + product.price);
                Console.WriteLine("Product Available Stock: " + product.stock + "\n");
            }
        }
        public static void ProductWithHighestPrice()
        {
            Product product = ProductDL.HighestPrice();
            Console.WriteLine("Product name: " + product.name);
            Console.WriteLine("Product Category: " + product.category);
            Console.WriteLine("Product Price: " + product.price);
            Console.WriteLine("Product Available Stock: " + product.stock + "\n");
        }
        public static void ViewProductsWithTax()
        {
            foreach (var product in ProductDL.products)
            {
                Console.WriteLine("Product name: " + product.name);
                Console.WriteLine("Product Category: " + product.category);
                Console.WriteLine("Product Price: " + product.price);
                Console.WriteLine("Product Tax: " + product.CalculateTax());
            }
        }
        public static void ProductsToBeOrdered()
        {
            foreach (var product in ProductDL.products)
            {
                if (product.ProductsLessThanMinStock())
                {
                    Console.WriteLine("Product name: " + product.name);
                    Console.WriteLine("Product Available Stock: " + product.stock);
                }
            }
        }

        //////////////////Costumer Functions Start///////////////
        public static char CustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to View all Products");
            Console.WriteLine("Press 2 to Buy Products");
            Console.WriteLine("press 3 to Generate Invoice");
            Console.WriteLine("Press 4 to EXIT");
            char op;
            op = char.Parse(Console.ReadLine());
            return op;
        }
        public static void BuyProduct(Customer cust)
        {
            Console.Write("Enter the name of Product you want to buy: ");
            string name = Console.ReadLine();
            Product p = ProductDL.IsProductAvailable(name);
            if (p != null)
            {
                if (p.IsStockAvailable())
                {
                    cust.AddProduct(p);
                    p.DecreaseProduct();
                }
            }
        }
        public static void GenerateInvoice(Customer cust)
        {
            Console.WriteLine("Customer Name: " + cust.name);
            Console.WriteLine("Total Price: " + cust.AllPrice());
            Console.WriteLine("Total Tax Applied: " + cust.AllTax());
        }

    }
}
