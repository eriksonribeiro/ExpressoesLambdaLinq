using System;
using System.Globalization;

namespace UsingComparisonT
{

    //Using IComparable
    public class ProductT: IComparable<ProductT>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductT(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(ProductT other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}
