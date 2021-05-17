
using System;
using System.Collections.Generic;

namespace UsingLinq.Entities
{
   public static class Model
    {
        public static List<Product> InstanceObjetcs()
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

           List<Product> products = new List<Product>() {
           new Product() { Id = 1,  Name = "Computer"  , Price = 1100.00, Category = c2},
           new Product() { Id = 2,  Name = "Hammer"    , Price =   90.00, Category = c1},
           new Product() { Id = 3,  Name = "TV"        , Price = 1700.00, Category = c3},
           new Product() { Id = 4,  Name = "Notebook"  , Price = 1300.00, Category = c2},
           new Product() { Id = 5,  Name = "Saw"       , Price =   80.00, Category = c1},
           new Product() { Id = 6,  Name = "Tablet"    , Price =  700.00, Category = c3},
           new Product() { Id = 7,  Name = "Camera"    , Price =  700.00, Category = c3},
           new Product() { Id = 8,  Name = "Printer"   , Price =  350.00, Category = c3},
           new Product() { Id = 9,  Name = "MacBook"   , Price = 1800.00, Category = c2},
           new Product() { Id = 10, Name = "Sound Bar" , Price =  700.00, Category = c3},
           new Product() { Id = 11, Name = "Level"     , Price =   70.00, Category = c1}
        };

            return products;

        }
        public static void PrintResult<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
                Console.WriteLine(obj);
            Console.WriteLine();
        }
    }
}
