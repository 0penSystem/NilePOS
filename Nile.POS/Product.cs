namespace Nile.Data
{
    /// <summary>
    /// An object representing a product in the the Nile POS system.
    /// </summary>
    public class Product
    {
        private static int _lastID = 0;
        string _name;
        decimal _unitPrice;

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
            get
            {
                return _name ?? "";
            }
            set
            {
                if (value == null)
                {
                    throw new System.ArgumentNullException("Name");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Price of one unit of the product in dollars.
        /// </summary>
        public decimal UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Unit Price must be greater than 0.");
                }
                _unitPrice = value;
            }
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