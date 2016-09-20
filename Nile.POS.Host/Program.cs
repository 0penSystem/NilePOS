using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.POS.Host
{
    class Program
    {
        
        static void Main(string[] args)
        {

           // pos = new POS();

            EntryMenu selectProduct = new EntryMenu("Select Product", "Please enter the product's ID Number:");
            EntryMenu selectCustomers = new EntryMenu("Select Customer", "Please insert the customer's ID Number:");

            





            // EntryMenu getProduct = new EntryMenu("Select Product", "Please insert the product's ID Number:", getCustomerObj);
            //EntryMenu getCustomer = new EntryMenu("Select Customer", "Please insert the customer's ID Number:", getCustomerObj);

            //MultiChoiceMenu manageCustomer = new MultiChoiceMenu("Manage Customers");
            //manageCustomer.AddOption('1', "Select Customer", new MultiChoiceMenu.OptionDelegate(getCustomer.Display)).AddOption('2', "Return to main menu", new MultiChoiceMenu.OptionDelegate(manageCustomer.Quit));

            //MultiChoiceMenu mainMenu = new MultiChoiceMenu("Main Menu");
            //mainMenu.AddOption('1', "Manage Customers", new MultiChoiceMenu.OptionDelegate(manageCustomer.Display)).AddOption('2', "Quit (will terminate program)", new MultiChoiceMenu.OptionDelegate(mainMenu.Quit));

            //mainMenu.Display();

            //}


            //static void getCustomerObj(string id)
            //{
            //    int ID;
            //    bool success = int.TryParse(id, out ID);
            //    if (success)
            //    {
            //        customer = pos.Customers.Get(ID);
            //    }
            //    if (!success || customer == null)
            //    {
            //        Console.Out.WriteLine("ID not found.");
            //        return;
            //    }

            //    order = customer.CurrentOrder;
            //    MultiChoiceMenu customerMenu = new MultiChoiceMenu($"{customer.ID}: {customer.FirstName} {customer.LastName} ${customer.CurrentOrder.TotalPrice}");
            //    customerMenu.AddOption('1', "Display Current Order", displayOrder)
            //        .AddOption('2', "Add Product to Order", addToOrder)
            //        .AddOption('3', "Remove Product from Order", customerMenu.Quit)
            //        .AddOption('4', "Finalize Order", customerMenu.Quit)
            //        .AddOption('5', "Return to Manage Customers Menu", customerMenu.Quit);

            //    customerMenu.Display();
            //}


            //static void displayOrder()
            //{

            //    Console.Out.WriteLine($"==={customer.FirstName} {customer.LastName}, {order.OrderDate}===");

            //    foreach (LineItem l in order.LineItems)
            //    {
            //        Console.Out.WriteLine($"{l.Product.Name} x {l.Quantity} @ ${l.Product.UnitPrice} {l.TotalPrice}");
            //    }

            //}


            //static void addToOrder()
            //{
            //    if (order.LineItems.Count >= 5)
            //    {
            //        Console.Out.WriteLine("Order is full. Please remove products before adding to this order.");
            //        return;
            //    }

            //    Console.Out.WriteLine("Please enter the Product's ID:");
            //    string id = Console.In.ReadLine();
            //    int ID;

            //    bool success = int.TryParse(id, out ID);
            //    if (success)
            //    {
            //        product = pos.Products.Get(ID);
            //    }
            //    if (!success || product == null)
            //    {
            //        Console.Out.WriteLine("ID not found.");
            //        return;
            //    }
            //    if (product.Discontinued)
            //    {
            //        Console.Out.WriteLine("Product has been discontinued, and cannot be ordered.");
            //        return;
            //    }

            //    success = false;
            //    int quantity = -999;
            //    while (!success)
            //    {
            //        Console.Out.WriteLine("Please enter the quantity to be ordered.");

            //        string input = Console.In.ReadLine();
            //        success = int.TryParse(input, out quantity);

            //        if (!success)
            //            Console.Out.WriteLine("Please enter a numeric value.");
            //        if (quantity < 1 || quantity > 100)
            //        {
            //            Console.Out.WriteLine("Quantity must be between 1 and 100.");
            //            success = false;
            //        }
            //    }

            //    order.LineItems.Add(new LineItem(product, quantity));


        }


    }
}
