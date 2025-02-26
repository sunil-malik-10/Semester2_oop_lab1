using System.Collections.Generic;

public class ProductDL
{
    public static List<ProductBL> Products = new List<ProductBL>();

    public static void AddProduct(ProductBL product)
    {
        Products.Add(product);
    }

    public static List<ProductBL> GetProducts()
    {
        return Products;
    }
}