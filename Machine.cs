namespace Straw
{
    public class Machine
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int ProductionRate { get; set; } // Straws per hour

        public Machine(string name, string type, int productionRate)
        {
            Name = name;
            Type = type;
            ProductionRate = productionRate;
        }


        public override string ToString()
        {
            return $"{Name} ({Type}) - Produces {ProductionRate} straws/hour";
        }
    }
}
