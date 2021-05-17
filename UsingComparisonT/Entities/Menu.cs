using System;
using System.Collections.Generic;

namespace UsingComparisonT
{
    public static class Menu
    {
        public static void UsingIComparable()
        {
            Console.WriteLine("1 - Using IComparable:");

            List<ProductT> list = new List<ProductT>();

            list.Add(new ProductT("TV", 900.00));
            list.Add(new ProductT("Notebook", 1200.00));
            list.Add(new ProductT("Tablet", 450.00));

            list.Sort();

            foreach (ProductT p in list)
                Console.WriteLine(p);
        }

        public static void UsingMethodReference()
        {
            Console.WriteLine("\n2 - Using Simple Method Reference:");
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort(CompareProducts);

            foreach (Product p in list)
                Console.WriteLine(p);
        }


        public static void UsingMethodReferenceVariable()
        {
            Console.WriteLine("\n3 - Using Simple Method Reference into a variable:");
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = CompareProducts;

            list.Sort(comp);

            foreach (Product p in list)
                Console.WriteLine(p);
        }


        public static void UsingLambdaVariable()
        {
            Console.WriteLine("\n4 - Using Lambda Expression into a variable:");
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            
            list.Sort(comp);

            foreach (Product p in list)
                Console.WriteLine(p);
        }


        public static void UsingLambdaExpression()
        {
            Console.WriteLine("\n5 - Using Lambda Expression into a variable:");
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
                Console.WriteLine(p);

            Console.ReadKey();
        }

        public static int CompareProducts(Product p1, Product p2)
        {
            //Comparison<T> public delegate int Comparison<int T>(Tx, T y);
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
