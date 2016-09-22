using System.Collections.Generic;

namespace Nile.POS
{
    public class Customers
    {
        private Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

        public Customer Get(int customerID)
        {
            try
            {
                return _customers[customerID];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

        }

        public void Add(Customer c)
        {
            _customers[c.ID] = c;
        }

        public Customers()
        {

            Customer[] _tempCustomers =
            {
                new Customer("Alice", "Baker", new Order()),
                new Customer("Caden", "Daniels", new Order()),
                new Customer("Evelyn", "Frank", new Order()),
                new Customer("George", "Hall", new Order()),
                new Customer("Irene", "Jacobs", new Order())
            };
            foreach (Customer c in _tempCustomers)
            {
                Add(c);
            }
        }

    }
}