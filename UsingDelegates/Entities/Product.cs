using System.Collections.Generic;

namespace UsingDelegates.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Produto: {Name} | Price: {Price.ToString("F2")}";
        }
        public static string ProductNameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        public static bool RemoveProduct(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}