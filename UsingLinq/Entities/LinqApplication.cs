using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingLinq.Entities
{
    public static class LinqApplication
    {
        public static void Execution()
        {
            try
            {
                List<Product> products = new List<Product>();
                products = Model.InstanceObjetcs();

                var result01 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
                Model.PrintResult(".Where(Tier = 1 and Price < 900.00)", result01);

                var result02 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
                Model.PrintResult(".Where(CategoryName = Tools).Select(Product Name)", result02);

                var result03 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
                Model.PrintResult(".Where(Name starts with C).Select(Product Name), Price, Categoty Name", result03);

                var result04 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
                Model.PrintResult(".Where(Tier = 1).Orderby(Product Price, Name)", result04);

                var result05 = result04.Skip(2).Take(4);
                Model.PrintResult(".Skip(2).Take(4)", result05);

                Console.WriteLine($".First(), {products.First()}");
                Console.WriteLine();
                Console.WriteLine($".FirstOrDefault(), {products.Where(p => p.Price > 3000).FirstOrDefault()}");
                Console.WriteLine();
                Console.WriteLine($".Single(), {products.Where(p => p.Id == 3).Single()}");
                Console.WriteLine();
                Console.WriteLine($".SingleOrDefault(), {products.Where(p => p.Id == 30).SingleOrDefault()}");
                Console.WriteLine();
                Console.WriteLine($".Max(Price), {products.Max(p => p.Price)}");
                Console.WriteLine();
                Console.WriteLine($".Min(Price), {products.Min(p => p.Price)}");
                Console.WriteLine();
                Console.WriteLine($".Sum(Price), {products.Where(p => p.Category.Id == 1).Sum(p => p.Price)}");
                Console.WriteLine();
                Console.WriteLine($".Average(Price), {products.Where(p => p.Category.Id == 1).Average(p => p.Price)}");
                Console.WriteLine();
                Console.WriteLine($".Average(Price) Result Null, {products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average()}");
                Console.WriteLine();
                Console.WriteLine($".Aggregate(Price), {products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y)}");
                Console.WriteLine();
                Console.WriteLine($".Aggregate(Price) Result Null, {products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y)}");
                Console.WriteLine();
                Console.WriteLine($".GroupBy(Category)");
                var result06 = products.GroupBy(p => p.Category);
                foreach (IGrouping<Category, Product> group in result06)
                {
                    Console.WriteLine($"Category {group.Key.Name}:");
                    foreach (Product p in group)
                        Console.WriteLine(p);
                }
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
