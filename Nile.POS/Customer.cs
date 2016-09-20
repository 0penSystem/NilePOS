using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.POS
{
    public class Customer
    {
        private static int _lastID = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private Order _currentOrder;

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public Order CurrentOrder
        {
            get
            {
                return _currentOrder;
            }
            set
            {
                _currentOrder = value;
            }
        }


        public Customer(string firstName, string lastName, Order currentOrder)
        {

            _id = ++_lastID;
            _firstName = firstName;
            _lastName = lastName;
            _currentOrder = currentOrder;
        }
    }
}