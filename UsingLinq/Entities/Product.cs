using System.Globalization;

namespace UsingLinq.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price; {Price.ToString("F2",CultureInfo.InvariantCulture)}, Category Name: {Category.Name}";
        }
    }


}
