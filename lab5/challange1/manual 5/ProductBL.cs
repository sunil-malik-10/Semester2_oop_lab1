public class ProductBL
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int Threshold { get; set; }

    public ProductBL(string name, string category, double price, int stock, int threshold)
    {
        Name = name;
        Category = category;
        Price = price;
        Stock = stock;
        Threshold = threshold;
    }

    public double CalculateSalesTax()
    {
        if (Category.ToLower() == "grocery")
            return Price * 0.10; // 10% tax for grocery
        else if (Category.ToLower() == "fruit")
            return Price * 0.05; // 5% tax for fruits
        else
            return Price * 0.15; // 15% tax for other categories
    }
}