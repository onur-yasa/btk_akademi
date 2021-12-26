using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.id = 1;
            product.Name = "Nasuh";
            product.Price = 500;

            Product product1 = new Product();
            product1.id = 2;
            product1.Name = "Elma";
            product1.Price = 50;

            Product[] products = new Product[]
            {
                product,product1
            };

            foreach (var kurs in products)
            {
                Console.WriteLine(kurs.id);
                Console.WriteLine(kurs.Name);
                Console.WriteLine(kurs.Price);
            }
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product İd");
                Console.WriteLine(products[i].id);
                Console.WriteLine("Product Name");
                Console.WriteLine(products[i].Name);
                Console.WriteLine("Product Price");
                Console.WriteLine(products[i].Price);
            }
            int j = 0;
            while (j < 2)
            {
                Console.WriteLine("Product İd");
                Console.WriteLine(products[j].id);
                Console.WriteLine("Product Name");
                Console.WriteLine(products[j].Name);
                Console.WriteLine("Product Price");
                Console.WriteLine(products[j].Price);
                j++;
            }
            
            Console.ReadLine();
        }
    }
    class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
