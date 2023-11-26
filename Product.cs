﻿

using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{

    public class Product
    {
        public Product(string name, string code, decimal price)
        {
            Name = name;
            Code = code;
            Price = price;
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
    }
    internal static class ProductListExtensions
    {
        internal static bool AddUnique(this List<Product> productList, Product productToAdd)
        {           
            if (!productList.Any(p => p.Code == productToAdd.Code))
            {
                productList.Add(productToAdd);
                return true;
            }
            else
            {
                throw new InvalidOperationException($"Product with code: {productToAdd.Code} already exists");
            }
        }
    }
}
