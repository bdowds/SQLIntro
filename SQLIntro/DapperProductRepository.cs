﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;

namespace SQLIntro
{
    public class DapperProductRepository : IRepository
    {
        private string connectionString;

        public DapperProductRepository(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public void CreateProduct(Product prod)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                conn.Execute("INSERT INTO product (Name, ListPrice) VALUES (@name, @price);", new { name =  prod.Name, price = prod.Price});
            }
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product prod)
        {
            throw new NotImplementedException();
        }
    }
}
