using System.Globalization;

namespace ExerciseLinqDemo.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Price: {Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
