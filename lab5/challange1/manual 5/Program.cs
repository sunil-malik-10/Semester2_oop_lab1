using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    var customer = CustomerDL.FindCustomer(username, password);
                    if (customer != null)
                    {
                        Console.WriteLine("Login Successful!");
                        CustomerUI.CustomerMenu(customer); // Open Customer Menu
                    }
                    else
                    {
                        Console.WriteLine("Invalid Username or Password.");
                    }
                    break;
                case "2":
                    CustomerUI.AddCustomer(); // Call AddCustomer() to register a new customer
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice! Try Again.");
                    break;
            }
        }
    }
}