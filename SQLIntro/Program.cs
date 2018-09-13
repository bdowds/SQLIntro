﻿using System;
using System.Collections.Generic;

namespace SQLIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository prodRepo = new ProductRepository();
            List<Product> products = prodRepo.GetProducts();

            foreach(Product product in products)
            {
                Console.WriteLine($"{product.Id} {product.Name}------${product.Price}\n");
            }
            Console.ReadLine();
        }
    }
}
