using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System.BL
{
    class Product
    {
        public string name;
        public string category;
        public float price;
        public int stock;
        public int min;

        public void Input()
        {
            Console.Write("Enter name of Product: ");
            name = Console.ReadLine();
            Console.Write("Enter category of Product: ");
            category = Console.ReadLine();
            Console.Write("Enter price of product: ");
            price = float.Parse(Console.ReadLine());
            Console.Write("Enter Stock available: ");
            stock = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum stock: ");
            min = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine(name + "\t" + category + "\t" + price + "\t" + stock);
        }
        public void TaxDisplay()
        {
            double tax;
            if (category == "grocery")
            {
                tax = 10;
            }
            else if (category == "fruit")
            {
                tax = 5;
            }
            else
            {
                tax = 15;
            }
            tax = (price * tax) / 100;
            Console.WriteLine(name + "\t\t" + tax);
        }
        public void Ordred()
        {
            if (min > stock)
            {
                Console.WriteLine(name + "\t\t" + stock);
            }
        }
        public int Highest(List<Product> p)
        {
            int idx = 0;
            float highP = p[0].price;

            for (int i = 0; i < p.Count; i++)
            {
                if (highP < p[i].price)
                {
                    idx = i;
                    highP = p[i].price;
                }
            }
            return idx;
        }
    }
}
