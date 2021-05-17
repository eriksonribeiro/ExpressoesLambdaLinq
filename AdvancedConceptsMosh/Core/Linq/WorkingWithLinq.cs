using System;
using System.Linq;

namespace AdvancedConceptsMosh
{
    partial class Program
    {
        public static class WorkingWithLinq
        {
            public static void LinqResults()
            {
                var books = new BookRepository().GetBooks();

                //Linq Query operators
                Console.WriteLine("\nQuery operators");
                var cheaperBooks1 = from b in books
                                    where b.price < 10
                                    orderby b.title
                                    select b;

                foreach (var book in cheaperBooks1)
                  Console.WriteLine($"Title: {book.title} | Price: {book.price}");

                //Linq Extension Methods
                Console.WriteLine("\nExtension Methods");
                var cheaperBooks2 = books.Where(b => b.price < 10).OrderBy(b => b.title);

                foreach (var book in cheaperBooks2)
                    Console.WriteLine($"Title: {book.title} | Price: {book.price}");
            }
        }
    }
}
