using System.Collections.Generic;

namespace Nile.Data
{
    public class Products
    {
        private Dictionary<int, Product> _products = new Dictionary<int, Product>();

        /// <summary>
        /// Returns the customer specified by the ID number.
        /// </summary>
        /// <param name="customerID">A customer ID that must be greater than 0.</param>
        /// <returns>The customer with the specified ID, or null if that customer does not exist.</returns>
        public Product Get(int customerID)

        {
            if (customerID <= 0)
            {
                throw new System.ArgumentException("IDs must be greater than 0.");
            }
            try
            {
                return _products[customerID];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }


        /// <summary>
        /// Gets a read-only list of the available customers.
        /// </summary>
        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>();
            foreach (var Product in _products)
            {
                list.Add(Product.Value);
            }
            return list;
        }
        
        public void Add(Product p)
        {
            if (_products.ContainsKey(p.ID))
            {
                throw new System.ArgumentException("Duplicate Product ID.");
            }
            _products[p.ID] = p;
        }

        public void Remove(int productID)
        {
            if (productID <= 0)
            {
                throw new System.ArgumentException("IDs must be greater than 0.");
            }

            if (_products.ContainsKey(productID))
            {
                _products.Remove(productID);
            }
            else
            {
                throw new System.ArgumentException("ID not found.");
            }


        }

        public void Update(Product p)
        {
            if (!_products.ContainsValue(p))
            {
                throw new System.ArgumentException("Product must be in the list of products.");
            }
            //TODO: whatever validation is supposed to do :v

        }
        public Products()
        {

        }

    }
}