using System;
using System.Collections.Generic;
using System.Linq;
using UsingDelegates.Entities;

namespace UsingDelegates.Services
{
    public static class ProductService
    {
        public static List<Product> CreateListOfProduct()
        {
          List<Product> list = new List<Product>();
          list.Add(new Product("TV", 900.00));
          list.Add(new Product("Mouse", 50.00));
          list.Add(new Product("Tablet", 350.50));
          list.Add(new Product("HD Case", 80.90));
          
          return list;
        }
        public static void UpperCaseName(int param, List<Product> list)
        {
            //Using Delegate Func
            List<string> upperList = new List<string>();

            switch (param)
            {
                case 1:
                    upperList = list.Select(Product.ProductNameUpper).ToList();
                    Console.WriteLine($"{param} - Reference Method");
                    break;
                case 2:
                    Func<Product, string> func1 = Product.ProductNameUpper;
                    upperList = list.Select(func1).ToList();
                    Console.WriteLine($"{param} - With Delegate function");
                    break;
                case 3:
                    Func<Product, string> func2 = p => p.Name.ToUpper();
                    upperList = list.Select(func2).ToList();
                    Console.WriteLine($"{param} - With Lambda Expression");
                    break;
                case 4:
                    upperList = list.Select(p => p.Name.ToUpper()).ToList();
                    Console.WriteLine($"{param} - Lambda Expression in line");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            foreach (string s in upperList)
                Console.WriteLine($"- {s}");
            Console.WriteLine("---------------------------------");
        }

        public static void ChangePrice(int param, List<Product> list)
        {
            //Using Delegate Action
            switch (param)
            {
                case 1:
                    list.ForEach(Product.UpdatePrice);
                    Console.WriteLine($"{param} - Reference Method");
                    break;
                case 2:
                    Action<Product> act1 = Product.UpdatePrice;
                    list.ForEach(act1);
                    Console.WriteLine($"{param} - With Delegate Action");
                    break;
                case 3:
                    Action<Product> act2 = p => { p.Price += p.Price * 0.1; };
                    list.ForEach(act2);
                    Console.WriteLine($"{param} - With Lambda Expression");
                    break;
                case 4:
                    list.ForEach(p => { p.Price += p.Price * 0.1; });
                    Console.WriteLine($"{param} - Lambda Expression in line");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            ShowProductList(list);
        }

        public static void RemoveProduct(int param, List<Product> list)
        {
            //public delegate bool Predicate<in T> (t obj);

            switch (param)
            {
                case 1:
                    list.RemoveAll(Product.RemoveProduct);
                    Console.WriteLine($"{param} - Reference Method");
                    break;
                case 2:
                    list.RemoveAll(p => p.Price >= 100.00);
                    Console.WriteLine($"{param} - Lambda Expression in line");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            ShowProductList(list);
        }

        public static void ShowProductList(List<Product> list)
        {
            foreach (Product product in list)
                Console.WriteLine(product);
            Console.WriteLine("---------------------------------");
        }
    }
}
