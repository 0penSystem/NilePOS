using System;
namespace Nile.Data
{
    /// <summary>
    /// Represents a lineitem in the Nile POS system.
    /// </summary>
    public class LineItem
    {

        Product _product;
        int _quantity;
        /// <summary>
        /// The product inside the lineitem.
        /// </summary>
        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product");
                }
                if (value.Discontinued)
                {
                    throw new ArgumentException("Discontinued Products cannot be used in a LineItem");
                }
                _product = value;
            }
        }

        /// <summary>
        /// The quantity of the product in the lineitem.
        /// </summary>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity must be greater than 0.");
                }
                _quantity = value;
            }
        }

        /// <summary>
        /// Total price of the quantity of products in the lineitem.
        /// </summary>
        public decimal TotalPrice
        {
            get
            {
                return Product.UnitPrice * Quantity;
            }
        }

        /// <summary>
        /// Represents a lineitem in the Nile POS system.
        /// </summary>
        /// <param name="product">Product in the lineitem.</param>
        /// <param name="quantity">Quantity of the product.</param>
        public LineItem(Product product, int quantity)
        {

            Quantity = quantity;
            Product = product;
        }

    }
}