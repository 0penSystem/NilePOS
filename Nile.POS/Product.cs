namespace Nile.POS
{
    /// <summary>
    /// An object representing a product in the the Nile POS system.
    /// </summary>
    public class Product
    {
        private static int _lastID = 0;

        /// <summary>
        /// An object representing a product in the the Nile POS system.
        /// </summary>
        /// <param name="name">Name of the product.</param>
        /// <param name="unitPrice">Price of one unit of the product in dollars.</param>
        /// <param name="discontinued">True if the product is discontinued.</param>
        public Product(string name, decimal unitPrice, bool discontinued)
        {
            ID = ++_lastID;
            Name = name;
            UnitPrice = unitPrice;
            Discontinued = discontinued;
        }

        /// <summary>
        /// Identification number of the product.
        /// </summary>
        public int ID
        {
            get; private set;
        }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name
        {
            get; private set;
        }

        /// <summary>
        /// Price of one unit of the product in dollars.
        /// </summary>
        public decimal UnitPrice
        {
            get; private set;
        }

        /// <summary>
        /// True if the product is discontinued.
        /// </summary>
        public bool Discontinued
        {
            get; private set;

        }
    }
}