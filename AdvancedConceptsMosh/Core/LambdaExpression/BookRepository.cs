using System.Collections.Generic;

namespace AdvancedConceptsMosh
{
    public class BookRepository 
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {title = "ADO.Net Step by Step", price = 5 },
                new Book() {title = "ASP.Net MVC", price = 10 },
                new Book() {title = "ASP.NET Web API", price = 12},
                new Book() {title = "C# Beginners", price = 7 },
                new Book() {title = "C# Advanced", price = 9 }
            };
        }
    
    }
}
