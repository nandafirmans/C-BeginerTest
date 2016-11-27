using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBook()
        {
            return new List<Book>()
            {
                  new Book() { Title = "Naruto", Price = 5000 },
                  new Book() { Title = "One Piece", Price = 10000 },
                  new Book() { Title = "Buku2", Price = 9000 },
                  new Book() { Title = "Anjay", Price = 1000 },
                  new Book() { Title = "Anjay Part 2", Price = 7000 },

            };
        }
    }
}
