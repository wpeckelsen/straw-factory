using Straw;

namespace StrawFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var productData = FactoryData.GetProductByID();

            Console.WriteLine("Straw Factory!!!");
            Console.WriteLine("search a product by ID");

            int entry = Convert.ToInt32(Console.ReadLine());

            if (productData.TryGetValue(entry, out Product foundProduct))
            {
                Console.WriteLine($"{foundProduct}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }





        }
    }
}