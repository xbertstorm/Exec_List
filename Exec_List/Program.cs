using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1, ProductName = "Apple", ProductPrice = 100, ProductNumber = 1},
                new Product{ ProductId = 2, ProductName = "Banana", ProductPrice = 250, ProductNumber = 5}
            };

            products.Add(new Product { ProductId = 3, ProductName = "Peach", ProductPrice = 150, ProductNumber = 3});

            foreach (var x in products)
            {
                Console.WriteLine($"{x.ProductId}    {x.ProductName}    {x.ProductPrice}    {x.ProductNumber}");
            }

            Console.Read();
		}
    }
    class Product
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductNumber { get; set; }
	}
}
