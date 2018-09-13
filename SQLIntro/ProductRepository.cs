using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SQLIntro
{
    class ProductRepository
    {
        private static string connectionString = "Server=localhost;Database=adventureworks;Uid=root;Pwd=password;";

        public List<Product> GetProducts()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ProductID AS id, name, ListPrice AS price FROM product;";
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Product> products = new List<Product>();
                while(reader.Read())
                {
                    Product prod = new Product();
                    prod.Id = (int)reader["id"];
                    prod.Name = reader["name"].ToString();
                    prod.Price = (double)reader["price"];

                    products.Add(prod);
                }
                return products;
            }  
        }


        public void CreateProduct(string n, double p)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO product (Name, ListPrice) VALUES (@name, @price)";
                cmd.Parameters.AddWithValue("name", n);
                cmd.Parameters.AddWithValue("price", p);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
