using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Customer
    {
        public Customer(string name, string address, string number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }
        public string name;
        public string address;
        public string number;
        public List<Product> product = new List<Product>();


        public void getAllProduct()
        {
            int totalP = 0;
            for (int i = 0; i < product.Count; i++)
            {
                product[i].viewP();
                totalP = totalP + product[i].Price;
            }
            Console.WriteLine("Total purchases price is: " + totalP);
        }
        public void AllTax()
        {
            float Ttax = 0;
            for (int i = 0; i < product.Count; i++)
            {
                float T = product[i].CalculateTax();
                Ttax = Ttax + T;
            }
            Console.WriteLine("Total tax for all purchases is: " + Ttax);
        }
    }
}
