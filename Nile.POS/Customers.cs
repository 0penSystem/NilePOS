using System.Collections.Generic;

namespace Nile.Data
{
    public class Customers
    {
        private Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

        public Customer Get(int customerID)
        {
            if (customerID <= 0)
            {
                throw new System.ArgumentException("IDs must be greater than 0.");
            }
            try
            {
                return _customers[customerID];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

        }

        public void Remove(int customerID)
        {
            if (customerID <= 0)
            {
                throw new System.ArgumentException("IDs must be greater than 0.");
            }
            try
            {
                _customers.Remove(customerID);
            }
            catch (KeyNotFoundException)
            {
                return;
            }

        }

        /// <summary>
        /// Gets a read-only list of the available customers.
        /// </summary>
        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();
            foreach (var Customer in _customers)
            {
                list.Add(Customer.Value);
            }
            return list;
        }

        public void Add(Customer c)
        {
            if (_customers.ContainsKey(c.ID))
            {
                throw new System.ArgumentException("Duplicate Customer ID.");
            }
            _customers[c.ID] = c;
        }


        public void Update(Customer c)
        {
            if (!_customers.ContainsValue(c))
            {
                throw new System.ArgumentException("Customer must be in the list of customers.");
            }
            //TODO: whatever validation is supposed to do :v

        }

        public Customers()
        {
        }

    }
}