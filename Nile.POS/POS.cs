using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.POS
{

    public class POS
    {
        private Customers _customers;
        private Products _products;


        public POS()
        {
            Customers = new Customers();
            Products = new Products();
        }

        public Customers Customers
        {
            get
            {
                return _customers;
            }

            set
            {
                _customers = value;
            }
        }

        public Products Products
        {
            get
            {
                return _products;
            }

            set
            {
                _products = value;
            }
        }
    }


}
