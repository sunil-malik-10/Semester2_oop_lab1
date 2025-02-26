using System;
using System.Linq;

public class CustomerUI
{
    public static void AddCustomer()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();
        Console.Write("Enter Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter Contact Number: ");
        string contact = Console.ReadLine();

        // Create a new CustomerBL object
        CustomerBL customer = new CustomerBL(username, password, email, address, contact);

        // Add the customer to the data layer
        CustomerDL.AddCustomer(customer);
        Console.WriteLine("Customer Added Successfully!");
    }

    public static void CustomerMenu(CustomerBL customer)
    {
        while (true)
        {
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Buy Products");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. View Profile");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewAllProducts();
                    break;
                case "2":
                    BuyProducts(customer);
                    break;
                case "3":
                    GenerateInvoice(customer);
                    break;
                case "4":
                    ViewProfile(customer);
                    break;
                case "5":
                    Console.WriteLine("Exiting Customer Menu...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice! Try Again.");
                    break;
            }
        }
    }

    public static void ViewAllProducts()
    {
        var products = ProductDL.GetProducts();
        if (products.Count > 0)
        {
            Console.WriteLine("All Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Category: {product.Category}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }
        else
        {
            Console.WriteLine("No products available.");
        }
    }

    public static void BuyProducts(CustomerBL customer)
    {
        ViewAllProducts();
        Console.Write("Enter Product Name to Buy: ");
        string productName = Console.ReadLine();

        var product = ProductDL.GetProducts().FirstOrDefault(p => p.Name == productName);
        if (product != null && product.Stock > 0)
        {
            product.Stock--;
            Console.WriteLine($"Product '{product.Name}' purchased successfully!");
        }
        else
        {
            Console.WriteLine("Product not found or out of stock.");
        }
    }

    public static void GenerateInvoice(CustomerBL customer)
    {
        double total = 0;
        var products = ProductDL.GetProducts();
        if (products.Count > 0)
        {
            Console.WriteLine("Invoice:");
            foreach (var product in products)
            {
                double salesTax = product.CalculateSalesTax();
                double totalPrice = product.Price + salesTax;
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Sales Tax: {salesTax}, Total: {totalPrice}");
                total += totalPrice;
            }
            Console.WriteLine($"Total Invoice Amount (including tax): {total}");
        }
        else
        {
            Console.WriteLine("No products available to generate invoice.");
        }
    }

    public static void ViewProfile(CustomerBL customer)
    {
        Console.WriteLine("Customer Profile:");
        Console.WriteLine($"Username: {customer.Username}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine($"Address: {customer.Address}");
        Console.WriteLine($"Contact: {customer.Contact}");
    }
}