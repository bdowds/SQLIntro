﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SQLIntro
{
    public interface IRepository
    {
        List<Product> GetProducts();
        void DeleteProduct(int id);
        void CreateProduct(Product prod);
        void UpdateProduct(Product prod);
    }
}
