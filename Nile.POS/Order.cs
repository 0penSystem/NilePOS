using System;
using System.Collections.Generic;

namespace Nile.POS
{
    /// <summary>
    /// Represents a customer's order.
    /// </summary>
    public class Order
    {

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
        /// The list of LineItems in the order.
        /// </summary>
        public List<LineItem> LineItems
        {
            get; set;
        }

        /// <summary>
        /// Represents a customer's order.
        /// </summary>
        /// <param name="lineItems">Any number of LineItems for the order.</param>
        public Order(params LineItem[] lineItems) : this()
        {            
            LineItems.AddRange(lineItems);
        }

        /// <summary>
        /// Represents a customer's order.
        /// </summary>
        /// <param name="lineItems">A list of LineItems for the order </param>
        public Order(List<LineItem> lineItems) : this()
        {
            LineItems = lineItems;
        }

        /// <summary>
        /// Represents a customer's order.
        /// </summary>
        public Order()
        {
            OrderDate = DateTime.Now;
            LineItems = new List<LineItem>();
        }
    }
}