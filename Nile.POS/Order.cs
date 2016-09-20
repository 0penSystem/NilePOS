using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.POS
{
    public class Order
    {
        private DateTime _orderDate;
        private List<LineItem> _lineItems;

        public decimal TotalPrice
        {
            get
            {
                decimal temp = 0;
                if(_lineItems?.Count > 1)
                foreach (LineItem l in _lineItems)
                {
                    temp += l.TotalPrice;
                }
                return temp;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }

            set
            {
                _orderDate = value;
            }
        }

        public List<LineItem> LineItems
        {
            get
            {
                return _lineItems;
            }

            set
            {
                _lineItems = value;
            }
        }

        public Order(params LineItem[] lineItems)
        {
            _lineItems.AddRange(lineItems);
        }

        public Order(List<LineItem> lineItems)
        {

            OrderDate = DateTime.Now;
            LineItems = lineItems;
        }
        

    }
}