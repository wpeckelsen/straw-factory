using Straw;

namespace StrawFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Straw Factory!!!");
            Console.WriteLine("Press 1 for products, press 2 for machines");


            int choice = Convert.ToInt32(Console.ReadLine());
            int entry = Convert.ToInt32(Console.ReadLine());
            var potentialMachine = FactoryData.Machines.TryGetValue(entry, out Machine foundMachine);
            var potentialProduct = FactoryData.Products.TryGetValue(entry, out Product foundProduct);



            if (choice == 1)
            {
                if (potentialProduct)
                {
                    Console.WriteLine($"{foundProduct}");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }

            }
            else
            {
                if (potentialMachine)
                {
                    Console.WriteLine($"{foundMachine}");
                }
                else
                {
                    Console.WriteLine("Machine not found.");
                }
            }






        }
    }
}