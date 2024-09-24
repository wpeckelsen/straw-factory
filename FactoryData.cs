namespace Straw
{
    public static class FactoryData
    {
        public static List<Machine> GetMachines()
        {
            return new List<Machine>{
                new Machine("Straw Maker 3000", "Oven", 300),
                new Machine("Eco machine", "electric", 340),
        };
        }


        public static List<Product> GetProducts()
        {
            return new List<Product>{
                new Product("eco straw", 0.89, "paper"),
                new Product("classic", 0.24, "plastic"),
            };
        }

        public static Dictionary<int, Product> GetProductByID()
        {
            return new Dictionary<int, Product>{
                {3941, new Product("eco straw", 0.89, "paper")},
                {1456, new Product("classic", 0.24, "plastic")}
            };

        }
    }
}