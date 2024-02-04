using Homework_3_1.Entity;
using Homework_3_1.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1.Repository
{
    public class BookRepository : IBookRepository
    {
        private List<BookEntity> books = new List<BookEntity>();
        public BookRepository()
        {
            books = new List<BookEntity>()
            {
                new BookEntity()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pride end Prejudice",
                    Author = "Jane Austen",
                    Price = 860,
                },
                new BookEntity()
                {
                    Id = Guid.NewGuid(),
                    Name = "Breakfast Tiffany's",
                    Author = "Truman Carot",
                    Price = 920,
                },
                new BookEntity()
                {
                    Id = Guid.NewGuid(),
                    Name = "The black cat",
                    Author = "Edgar Allan Poe",
                    Price = 1020,
                },
                new BookEntity()
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Eyer",
                    Author = "Charlotte Bronte",
                    Price = 640,
                },
            };
        }
        public Guid AddBook(BookEntity book)
        {
            book.Id = Guid.NewGuid();
            books.Add(book);
            return book.Id;
        }

        public List<BookEntity> GetBooks()
        {
            return books;
        }
    }
}
