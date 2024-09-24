namespace Straw
{


    public class Product
    {


        public string Name { get; set; }
        public double Price { get; set; }
        public string Material { get; set; }

        public Product(string name, double price, string material)
        {
            Name = name;
            Price = price;
            Material = material;
        }

        public override string ToString()
        {
            return $"name: {Name} - price: ${Price} - material: {Material}";
        }
    }
}