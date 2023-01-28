using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Sales_Application.BL
{
    class Customer
    {
        public Customer(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
            product = new List<Product>();
            //this.address = address;
            //this.number = number;
        }
        public string name;
        public string pass;
        //public string address;
        //public string number;
        public List<Product> product;


        public void AddProduct(Product p)
        {
            product.Add(p);
        }

        public float AllTax()
        {
            float Ttax = 0;
            for (int i = 0; i < product.Count; i++)
            {
                Ttax += product[i].CalculateTax();
            }
            //Console.WriteLine("Total tax for all purchases is: " + Ttax);
            return Ttax;
        }
        public double AllPrice()
        {
            double Price = 0;
            for (int i = 0; i < product.Count; i++)
            {
                Price += product[i].price;
            }
            return Price;
        }
    }
}
