namespace Nile.POS
{
    /// <summary>
    /// Represents a Customer in the Nile POS system.
    /// </summary>
    public class Customer
    {
        private static int _lastID = 0;


        /// <summary>
        /// Identification number of the customer
        /// </summary>
        public int ID
        {
            get; private set;
        }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        public string FirstName
        {
            get; private set;
        }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        public string LastName
        {
            get; private set;
        }

        /// <summary>
        /// The customer's current order.
        /// </summary>
        public Order CurrentOrder
        {
            get; set;
        }


        /// <summary>
        /// Represents a Customer in the Nile POS system.
        /// </summary>
        /// <param name="firstName">The customer's first name.</param>
        /// <param name="lastName">The customer's last name.</param>
        /// <param name="currentOrder">The customer's current order.</param>
        public Customer(string firstName, string lastName, Order currentOrder)
        {
            ID = ++_lastID;
            FirstName = firstName;
            LastName = lastName;
            CurrentOrder = currentOrder;
        }
    }
}