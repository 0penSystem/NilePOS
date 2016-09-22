namespace Nile.POS
{
    /// <summary>
    /// Represents a lineitem in the Nile POS system.
    /// </summary>
    public class LineItem
    {

        /// <summary>
        /// The product inside the lineitem.
        /// </summary>
        public Product Product
        {
            get; private set;
        }

        /// <summary>
        /// The quantity of the product in the lineitem.
        /// </summary>
        public int Quantity
        {
            get; set;
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