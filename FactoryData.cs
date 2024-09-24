namespace Straw
{
    public static class FactoryData
    {
        public static Dictionary<int, Machine> Machines = new Dictionary<int, Machine>{
            { 3941, new Machine("ecoMachine", "Green", 3310) },
            { 1456, new Machine("classicMachine", "Blue", 2200) },
            { 5623, new Machine("biodegradableMachine", "Yellow", 2800) },
            { 2764, new Machine("bambooMachine", "Brown", 4100) },
            { 7890, new Machine("premiumMachine", "Silver", 5000) },
            { 6437, new Machine("flexiMachine", "Red", 1800) },
            { 9124, new Machine("glassMachine", "Transparent", 4700) },
            { 8345, new Machine("siliconeMachine", "Purple", 3600) }
        };

        public static Dictionary<int, Product> Products = new Dictionary<int, Product>
        {
            { 3941, new Product("eco straw", 0.89, "paper") },
            { 1456, new Product("classic straw", 0.24, "plastic") },
            { 7890, new Product("premium straw", 1.99, "metal") },
            { 5623, new Product("biodegradable straw", 1.49, "cornstarch") },
            { 2764, new Product("bamboo straw", 2.29, "bamboo") },
            { 6437, new Product("flexible straw", 0.19, "plastic") },
            { 9124, new Product("glass straw", 3.49, "glass") },
            { 8345, new Product("reusable silicone straw", 1.75, "silicone") }
        };
    }
}