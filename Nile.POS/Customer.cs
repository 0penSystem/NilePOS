using System;

namespace Nile.Data
{
    /// <summary>
    /// Represents a Customer in the Nile POS system.
    /// </summary>
    public class Customer
    {
        private static int _lastID = 0;
        private string _fName, _lName;
        
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
            get
            {
                return _fName ?? "";
            }
              set
            {
                _fName = value;
            }
        }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return _lName ?? "";
            }
            set
            {
                _lName = value;
            }
        }

        /// <summary>
        /// The customer's current order.
        /// </summary>
        public Order CurrentOrder
        {
            get; private set;
        }


        /// <summary>
        /// Represents a Customer in the Nile POS system.
        /// </summary>
        /// <param name="firstName">The customer's first name.</param>
        /// <param name="lastName">The customer's last name.</param>
        /// <param name="currentOrder">The customer's current order.</param>
        public Customer(string firstName, string lastName, Order currentOrder)
        {
            if (firstName == null || lastName == null)
            {
                throw new ArgumentNullException();
            }
            
            ID = ++_lastID;
            FirstName = firstName;
            LastName = lastName;
            CurrentOrder = currentOrder ?? new Order();



        }
    }
}