using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseLinqDemo.Entities
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            List<Product> productList = ProductOperation.ImportProductListCSV();

            foreach (var product in productList)
                Console.WriteLine(product);
            Console.WriteLine();

            double avgPriceList = ProductOperation.ProductPriceAVG(productList);
            Console.WriteLine($"Average price = {avgPriceList.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            IEnumerable<string> productsName = ProductOperation.ProductPriceLowerAVG(productList);
            foreach (var item in productsName)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
