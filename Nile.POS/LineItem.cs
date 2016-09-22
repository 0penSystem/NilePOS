using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.POS
{
    public class LineItem
    {

        public Product Product
        {
            get; private set;
        }

        public int Quantity
        {
            get; set;
        }

        public decimal TotalPrice
        {
            get
            {
                return Product.UnitPrice * Quantity;
            }
        }

        public LineItem(Product product, int quantity)
        {
            Quantity = quantity;
            Product = product;
        }

    }
}