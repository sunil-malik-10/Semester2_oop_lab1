using System;
using System.Linq;

public class AdminUI
{
    public static void AddAdmin()
    {
        Console.Write("Enter Admin Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter Admin Password: ");
        string password = Console.ReadLine();

        AdminBL admin = new AdminBL(username, password);
        AdminDL.AddAdmin(admin);
        Console.WriteLine("Admin Added Successfully!");
    }

    public static void ViewProfile(AdminBL admin)
    {
        Console.WriteLine($"Username: {admin.Username}");
    }

    public static void AdminMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered");
            Console.WriteLine("6. View Profile");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ProductUI.AddProduct();
                    break;
                case "2":
                    ProductUI.ViewProducts();
                    break;
                case "3":
                    ProductUI.ViewHighestPriceProduct();
                    break;
                case "4":
                    ProductUI.ViewSalesTaxOfAllProducts();
                    break;
                case "5":
                    ProductUI.ViewProductsBelowThreshold();
                    break;
                case "6":
                    ViewProfile(AdminDL.GetAdmins().First());
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid Choice! Try Again.");
                    break;
            }
        }
    }
}