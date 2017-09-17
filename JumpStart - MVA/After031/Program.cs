using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace After031
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseEntities();

            var products = context.PRODUCTS;

            foreach (var product in products.Where(x => x.NAME.Contains("a")))
                Console.WriteLine(product.NAME);
            
            var producto = products.First(x => x.NAME.StartsWith("S"));
            Console.WriteLine(producto.NAME);

            producto.NAME = "Santos";
            context.SaveChanges();

            products.Remove(producto);
            context.SaveChanges(); 

            Console.ReadKey();
        }
    }
}
