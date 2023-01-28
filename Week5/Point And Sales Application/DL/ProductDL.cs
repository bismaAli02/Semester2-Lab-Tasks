using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Sales_Application.BL;

namespace Point_And_Sales_Application.DL
{
    class ProductDL
    {
        public static List<Product> products = new List<Product>();
        public static void AddInList(Product product)
        {
            products.Add(product);
        }

        public static Product HighestPrice()
        {
            //products.Max(z.price=>)
            //products.Sort((x, y) => x.price.CompareTo(y.price));
            List<Product> SortedProducts = new List<Product>();
            SortedProducts = products.OrderByDescending(o => o.price).ToList();
            return products[0];
        }
        public static Product IsProductAvailable(string name)
        {
            foreach (var prod in products)
            {
                if (prod.name == name)
                {
                    return prod;
                }
            }
            return null;
        }
    }
}
