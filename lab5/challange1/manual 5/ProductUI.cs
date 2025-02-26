using System;
using System.Linq;

public class ProductUI
{
    public static void AddProduct()
    {
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Category (Grocery/Fruit/Other): ");
        string category = Console.ReadLine();
        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter Stock Quantity: ");
        int stock = int.Parse(Console.ReadLine());
        Console.Write("Enter Minimum Stock Threshold: ");
        int threshold = int.Parse(Console.ReadLine());

        ProductBL product = new ProductBL(name, category, price, stock, threshold);
        ProductDL.AddProduct(product);
        Console.WriteLine("Product Added Successfully!");
    }

    public static void ViewProducts()
    {
        var products = ProductDL.GetProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Category: {product.Category}, Price: {product.Price}, Stock: {product.Stock}, Threshold: {product.Threshold}");
        }
    }

    public static void ViewHighestPriceProduct()
    {
        var product = ProductDL.GetProducts().OrderByDescending(p => p.Price).FirstOrDefault();
        if (product != null)
            Console.WriteLine($"Highest Price Product: {product.Name} (Price: {product.Price})");
        else
            Console.WriteLine("No products available.");
    }

    public static void ViewSalesTaxOfAllProducts()
    {
        var products = ProductDL.GetProducts();
        foreach (var product in products)
        {
            double salesTax = product.CalculateSalesTax();
            Console.WriteLine($"Name: {product.Name}, Sales Tax: {salesTax}");
        }
    }

    public static void ViewProductsBelowThreshold()
    {
        var products = ProductDL.GetProducts().Where(p => p.Stock < p.Threshold).ToList();
        if (products.Count > 0)
        {
            Console.WriteLine("Products Below Threshold:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Stock: {product.Stock}, Threshold: {product.Threshold}");
            }
        }
        else
        {
            Console.WriteLine("No products below threshold.");
        }
    }
}