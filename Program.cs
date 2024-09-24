using Straw;

namespace StrawFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Straw Factory!!!");
            Console.WriteLine("Press 1, 2, 3, 4");
            int choice = Convert.ToInt32(Console.ReadLine());




            // static void returnNames()
            // {
            //     var productsByName = FactoryData.Products
            //          .Select(p => p.Value.Name)
            //          .ToList();
            //     foreach (var name in productsByName)
            //     {
            //         Console.WriteLine(name);
            //     }
            // }

            // static void returnCheapestProduct()
            // {
            //     var orderedByPrice = FactoryData.Products
            //     .OrderBy(p => p.Value.Price);
            //     var cheapestProduct = orderedByPrice.First();
            //     string productName = cheapestProduct.Value.Name;
            //     double productPrice = cheapestProduct.Value.Price;
            //     Console.WriteLine($"{productName}, {productPrice}");
            // }







            switch (choice)
            {
                case 1:
                    int productEntry = Convert.ToInt32(Console.ReadLine());
                    var potentialProduct = FactoryData.Products.TryGetValue(productEntry, out Product foundProduct);
                    if (potentialProduct)
                    {
                        Console.WriteLine($"{foundProduct}");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;

                case 2:
                    int machineEntry = Convert.ToInt32(Console.ReadLine());
                    var potentialMachine = FactoryData.Machines.TryGetValue(machineEntry, out Machine foundMachine);
                    if (potentialMachine)
                    {
                        Console.WriteLine($"{foundMachine}");
                    }
                    else
                    {
                        Console.WriteLine("Machine not found.");
                    }
                    break;

                case 3:
                    Operations.returnNames();
                    break;

                case 4:
                Operations.returnCheapestProduct();
                break;
            }








        }
    }
}