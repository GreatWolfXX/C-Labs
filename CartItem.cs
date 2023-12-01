using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CartItem
    {
        public Product Product {  get; set; }
        public int Count {  get; set; }

        public CartItem(Product product, int count)
        {
            Product = product; 
            Count = count;
        } 
    }
}
