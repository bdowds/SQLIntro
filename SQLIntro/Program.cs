using System;
using System.Collections.Generic;

namespace SQLIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository prodRepo = new ProductRepository();


            //List<Product> products = prodRepo.GetProducts();

            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"{product.Id} {product.Name}------${product.Price}\n");
            //}


            Console.WriteLine("Creating Product...");

            var newProduct = new Product { Name = "NewProduct", Price = 100 };

            prodRepo.CreateProduct(newProduct);


            Console.WriteLine("Product Created!");

            //Console.WriteLine("Updating Product...");
            //prodRepo.UpdateProduct(1004, "Updated", 100);
            //Console.WriteLine("Product Updated!");

            //Console.WriteLine("Deleting Product...");
            //prodRepo.DeleteProduct("NewPro");
            //Console.WriteLine("Product Deleted!");

            Console.ReadLine();
        }
    }
}
