using System;

namespace AdvancedConceptsMosh
{
    public static class LambdaExpressionConcepts
    {
        public static void CheapBooks()
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.price < 10);

            foreach (var book in cheapBooks)
                Console.WriteLine($"Title: {book.title} | Price: {book.price}");
        }
    }
}
