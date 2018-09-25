﻿using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace SQLIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
#if DEBUG
                .AddJsonFile("appsettings.Debug.json")
#else
                .AddJsonFile("appsettings.Release.json")
#endif
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            //ProductRepository prodRepo = new ProductRepository(connString);
            var addressRepo = new AddressRepository(connString);

            var address = new Address();
            address.Address1 = "123 Main St";
            address.Address2 = "3.14 Sesame St";
            address.City = "Hoover";
            address.ProvinceId = 3;
            address.PostalCode = "35244";

            Console.WriteLine("Creating Address...");
            addressRepo.CreateAddress(address);
            Console.WriteLine("Address Created!");





            //List<Product> products = prodRepo.GetProducts();

            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"{product.Id} {product.Name}------${product.Price}\n");
            //}


            //Console.WriteLine("Creating Product...");

            //var newProduct = new Product { Name = "NewProduct", Price = 100 };

            //prodRepo.CreateProduct(newProduct);


            //Console.WriteLine("Product Created!");

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
