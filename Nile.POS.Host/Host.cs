﻿using System;

namespace Nile.Data.Host
{
    class Host
    {
        POS _pos;

        /// <summary>
        /// Console based host for the Nile POS system.
        /// </summary>
        /// <param name="pos">Nile POS object</param>
        public Host(POS pos)
        {
            _pos = pos;
            MainMenu();
        }

        private void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("=== Main Menu ===");
                Console.ResetColor();
                Console.WriteLine("1. Manage Customers");
                Console.WriteLine("2. Quit Application");

                var keypress = Console.ReadKey();

                switch (keypress.KeyChar)
                {
                    case '1':
                        ManageCustomers();
                        break;
                    case '2':
                        return;
                }


            }
        }

        private void ManageCustomers()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("=== Manage Customers ===");
                Console.ResetColor();
                Console.WriteLine("1. Select Customer");
                Console.WriteLine("2. Return to Main Menu");

                var keypress = Console.ReadKey();

                switch (keypress.KeyChar)
                {
                    case '1':
                        CustomerMenu(SelectCustomer());
                        break;
                    case '2':
                        return;
                }


            }
        }

        private Customer SelectCustomer()
        {
            string temp = "";
            int id = -1;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the Customer's ID: ");
            Console.ResetColor();
            temp = Console.ReadLine();
            if (int.TryParse(temp, out id))
            {
                return _pos.Customers.Get(id);
            }

            return null;
        }

        private Product SelectProduct()
        {
            string temp = "";
            int id = -1;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the Product's ID: ");
            Console.ResetColor();
            temp = Console.ReadLine();
            if (int.TryParse(temp, out id))
            {
                return _pos.Products.Get(id);
            }

            return null;
        }

        private void CustomerMenu(Customer c)
        {
            if (c == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No customer with that ID found.");
                Console.ReadKey();
                Console.ResetColor();
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"=== {c.ID}: {c.FirstName} {c.LastName} ${c.CurrentOrder.TotalPrice} ===");
                Console.ResetColor();
                Console.WriteLine("1. Display Current Order");
                Console.WriteLine("2. Add a Product to the Order");
                Console.WriteLine("3. Remove a Product from the Order");
                Console.WriteLine("4. Finalize the Order");
                Console.WriteLine("5. Return to the Manage Customers Menu");

                var keypress = Console.ReadKey();

                switch (keypress.KeyChar)
                {
                    case '1':
                        DisplayOrder(c);
                        break;
                    case '2':
                        AddToOrder(c);
                        break;
                    case '3':
                        RemoveFromOrder(c);
                        break;
                    case '4':
                        FinalizeOrder(c);
                        break;
                    case '5':
                        return;
                }


            }


        }

        private void AddToOrder(Customer c)
        {
            Order o = c.CurrentOrder;

            Console.Clear();
            if (o.LineItems.Count > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Order is full. Please remove items before adding more.");
                Console.ReadKey();
                Console.ResetColor();
                return;
            }

            Product p = SelectProduct();

            if (p == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No product with that ID found.");
                Console.ReadKey();
                Console.ResetColor();
                return;
            }
            else if (p.Discontinued)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{p.Name} is discontinued and cannot be added.");
                Console.ReadKey();
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter a quantity between 1 and 100:");
            Console.ResetColor();
            string temp = Console.ReadLine();
            int quantity = -1;

            if (int.TryParse(temp, out quantity))
            {
                if (quantity < 0 || quantity > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quantity must be between 1 and 100.");
                    Console.ReadKey();
                    Console.ResetColor();
                    return;
                }

                o.LineItems.Add(new LineItem(p, quantity));
                DisplayOrder(c);
                return;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Quantity must be between 1 and 100.");
            Console.ReadKey();
            Console.ResetColor();


        }


        private void RemoveFromOrder(Customer c)
        {
            Product p = SelectProduct();
            c.CurrentOrder.LineItems.RemoveAll(x => x.Product == p);

        }

        private void FinalizeOrder(Customer c)
        {
            if (c.CurrentOrder.LineItems.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Empty order, cannot Finalize.");
                Console.ReadKey();
                Console.ResetColor();
                return;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=== Finalize Order ===");
            Console.ResetColor();
            Console.WriteLine("Are you sure?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            var keypress = Console.ReadKey();

            switch (keypress.KeyChar)
            {
                case '1':
                case 'y':
                case 'Y':
                    //what the heck does finalizing even do 
                    DisplayOrder(c);
                    break;
                case '2':
                case 'n':
                case 'N':
                    return;
            }


        }

        private void DisplayOrder(Customer c)
        {

            Console.Clear();
            Order o = c.CurrentOrder;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"=== {c.FirstName} {c.LastName} {c.CurrentOrder.OrderDate:g} ===");
            Console.ResetColor();

            foreach (LineItem l in o.LineItems)
            {
                Console.WriteLine($"{l.Product.Name} x {l.Quantity} @ ${l.Product.UnitPrice} = ${l.TotalPrice}");
            }
            Console.WriteLine($"Total Price is ${o.TotalPrice}");
            Console.Read();
        }


    }
}
