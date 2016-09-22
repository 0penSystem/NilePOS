using System.Collections.Generic;

namespace Nile.POS
{
    public class Products
    {
        private Dictionary<int, Product> _products = new Dictionary<int, Product>();
        
        public Product Get(int productID)
        {
            try
            {
                return _products[productID];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

        }

        public void Add(Product p)
        {
            _products[p.ID] = p;
        }


        

        public Products()
        {
            Product[] _tempProduct = {
                new Product("Super Bouncy Ball", 4.00m, false),
                new Product("Roundest Object on Earth", 2.15m, false),
                new Product("Magic 8-Ball", 8.88m, false),
                new Product("Golf Ball", 6.00m, false),
                new Product("Generic Spherical Object", 2.15m, false),
                new Product("Apple", 2.36m, false),
                new Product("Lemon", 3.13m, false),
                new Product("Lime", 20.16m, false),
                new Product("Earth", 1400.65m, true),
                new Product("Atom", 0.05m, true)
            };
            foreach (Product p in _tempProduct)
            {
                Add(p);
            }
        }

    }
}