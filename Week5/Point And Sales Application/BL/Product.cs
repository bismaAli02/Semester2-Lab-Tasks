using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Sales_Application.BL
{
    class Product
    {
        public Product()
        {
            // Default Constructor
        }
        public Product(string name, string category, int price, int stock, int minStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minStock = minStock;
        }
        public string name;
        public string category;
        public int price;
        public int stock;
        public int minStock;

        public float CalculateTax()
        {
            float tax;
            if (category == "FRUIT" || category == "Fruit" || category == "fruit")
            {
                tax = 10F;
            }
            else if (category == "GROCERY" || category == "Grocery" || category == "grocery")
            {
                tax = 5F;
            }
            else
            {
                tax = 15F;
            }
            tax = price * tax / 100;
            return tax;
        }
        public bool ProductsLessThanMinStock()
        {
            if (this.stock < this.minStock)
            {
                return true;
            }
            return false;
        }

        public bool IsStockAvailable()
        {
            if (this.stock > 0)
            {
                return true;
            }
            return false;
        }
        public void DecreaseProduct()
        {
            stock--;
        }
    }
}
