using System;
using System.Collections.Generic;

namespace Nile.Data
{
    /// <summary>
    /// Represents a customer's order.
    /// </summary>
    public class Order
    {
        List<LineItem> _lineItems = new List<LineItem>();

        /// <summary>
        /// The total price of all lineitems in the order.
        /// </summary>
        public decimal TotalPrice
        {
            get
            {
                decimal temp = 0;
                if (LineItems?.Count > 0)
                {

                    foreach (LineItem l in LineItems)
                    {
                        temp += l.TotalPrice;
                    }
                }
                return temp;
            }
        }

        /// <summary>
        /// The date on which the order was made.
        /// </summary>
        public DateTime OrderDate
        {
            get; set;
        }

        /// <summary>
        /// A readonly list of LineItems in the order.
        /// </summary>
        public IReadOnlyList<LineItem> LineItems
        {
            get
            {
                if (_lineItems == null)
                {
                    throw new NullReferenceException();
                }
                return _lineItems.AsReadOnly();
            }
        }


        /// <summary>
        /// Is true if the order is complete.
        /// </summary>
        public bool IsComplete
        {
            get; private set;
        }

        /// <summary>
        /// Represents a customer's order.
        /// </summary>
        /// <param name="lineItems">Any number of LineItems for the order.</param>
        public Order(params LineItem[] lineItems) : this()
        {
            _lineItems.AddRange(lineItems);
        }

        /// <summary>
        /// Represents a customer's order.
        /// </summary>
        /// <param name="lineItems">A list of LineItems for the order </param>
        public Order(List<LineItem> lineItems) : this()
        {
            _lineItems = lineItems;
        }

        /// <summary>
        /// Represents a customer's order.
        /// </summary>
        public Order()
        {
            OrderDate = DateTime.Now;
        }



        public void AddLineItem(LineItem l)
        {
            if (l == null)
            {
                throw new ArgumentNullException();
            }
            if (IsComplete)
            {
                throw new Exception("Cannot add to a completed order.");
            }

            foreach (LineItem _l in _lineItems)
            {
                if (_l.Product == l.Product)
                {
                    _l.Quantity += l.Quantity;
                    return;
                }
            }

            _lineItems.Add(l);
        }

        public void Complete()
        {
            if (IsComplete)
            {
                throw new Exception("Cannot complete a completed order.");
            }
            if (_lineItems.Count <= 0)
            {
                throw new Exception("Order must have at least one line item.");
            }
            IsComplete = true;
        }


    }
}