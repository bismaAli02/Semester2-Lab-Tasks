using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Product
    {
        public Product()
        {
            // Default Constructor
        }
        public Product(string name, string category, int Price)
        {
            this.name = name;
            this.category = category;
            this.Price = Price;
        }
        public string name;
        public string category;
        public int Price;
        public void viewP()
        {
            Console.WriteLine("Name: " + name + "\nCategory: " + category + "\nPrice: " + Price + "\n\n");
        }
        public float CalculateTax()
        {
            float tax;
            if (category == "f")
            {
                tax = 10F;
            }
            else if (category == "g")
            {
                tax = 5F;
            }
            else
            {
                tax = 15F;
            }
            tax = Price * tax / 100;
            return tax;
        }
    }
}
