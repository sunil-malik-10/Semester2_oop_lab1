using System.Collections.Generic;
using System.Linq;

public class CustomerDL
{
    public static List<CustomerBL> Customers = new List<CustomerBL>();

    public static void AddCustomer(CustomerBL customer)
    {
        Customers.Add(customer);
    }

    public static List<CustomerBL> GetCustomers()
    {
        return Customers;
    }

    public static CustomerBL FindCustomer(string username, string password)
    {
        return Customers.FirstOrDefault(c => c.Username == username && c.Password == password);
    }
}