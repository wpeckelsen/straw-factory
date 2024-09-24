namespace Straw
{
    public static class Operations
    {
 public static void returnNames(){
        var productsByName = FactoryData.Products
             .Select(p => p.Value.Name)
             .ToList();
        foreach (var name in productsByName)
        {
            Console.WriteLine(name);
        }
    }

    public static void returnCheapestProduct()
    {
        var orderedByPrice = FactoryData.Products
        .OrderBy(p => p.Value.Price);
        
        var cheapestProduct = orderedByPrice.First();

        string productName = cheapestProduct.Value.Name;
        double productPrice = cheapestProduct.Value.Price;
        Console.WriteLine($"{productName}, {productPrice}");
    }

    }
}