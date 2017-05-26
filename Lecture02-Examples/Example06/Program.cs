using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[4];
            products[0] = new Product()
            {
                Name = "iPhone 7",
                Price = 28900
            };
            products[1] = new Product()
            {
                Name = "iPhone 7+",
                Price = 29900
            };
            products[2] = new Product()
            {
                Name = "iPhone 8",
                Price = 31900
            };
            products[3] = new Product()
            {
                Name = "iPhone 8+",
                Price = 33900
            };

            Random random = new Random();
            List<Product> shoppingCart = new List<Product>
                ();
            for(var count = 1; count <= 10; count++)
            {
                var index = random.Next(0, products.Length);
                shoppingCart.Add(products[index]);
                Console.WriteLine(products[index].Name);
            }
        }
    }
}
