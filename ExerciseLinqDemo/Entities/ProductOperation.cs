using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExerciseLinqDemo.Entities
{
    public static class ProductOperation
    {
        public static List<Product> ImportProductListCSV()
        {
            List<Product> productList = new List<Product>();
            try
            {
                Console.Write("Enter with the directory path:");
                string path = Console.ReadLine();
                DirectoryInfo directory = new DirectoryInfo(path);

                if (directory.Exists)
                {
                    foreach (var file in directory.GetFiles("*.csv"))
                    {
                        Console.WriteLine($"Importing file:{file.Name} ");
                        using (StreamReader reader = File.OpenText(path + file.Name))
                            while (!reader.EndOfStream)
                            {
                                string[] fields = reader.ReadLine().Split(';');
                                string name = fields[0];
                                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                                productList.Add(new Product(name, price));
                            }
                        Console.WriteLine($"File imported with sucess!");
                        Console.WriteLine();
                    }
                    return productList;
                }
                else
                {
                    Console.WriteLine("Directory filled does not exist");
                    return productList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return productList;
            }
        }

        public static double ProductPriceAVG(List<Product> productList)
        {
            double avgPrice = productList.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            return avgPrice;
        }

        public static IEnumerable<string> ProductPriceLowerAVG(List<Product> productList)
        {
            double avgPrice = ProductPriceAVG(productList);
            IEnumerable<string> names = productList.Where(p => p.Price < avgPrice).OrderByDescending(p => p.Name).Select(p => p.Name);
            return names;
        }
    }
}
