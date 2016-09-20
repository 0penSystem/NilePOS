using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.POS
{
    public class LineItem
    {
        private Product _product;
        private int _quantity;

        public Product Product
        {
            get
            {
                return _product;
            }

            set
            {
                _product = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return _product.UnitPrice * _quantity;
            }
        }

        public LineItem(Product product, int quantity)
        {
            _quantity = quantity;
            _product = product;
        }

    }
}