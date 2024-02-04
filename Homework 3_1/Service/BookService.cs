using Homework_3_1.Entity;
using Homework_3_1.Model;
using Homework_3_1.Repository.Abstraction;
using Homework_3_1.Service.Abstaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        { 
            _bookRepository = bookRepository;
        }
        public  Guid AddBook(Book book)
        {
            var bookEntity = new BookEntity()
            {
                Name = book.Name,
                Author = book.Author,
                Price = book.Price
            };
            var Id = _bookRepository.AddBook(bookEntity);
            return Id;
        }

        public List<Book> GetBooks()
        {
            var bookEntities = _bookRepository.GetBooks();
            var books = new List<Book>();

            foreach(var bookEntity in bookEntities)
            {
                books.Add(new Book()
                {
                    Id = bookEntity.Id,
                    Name = bookEntity.Name,
                    Author = bookEntity.Author,
                    Price = bookEntity.Price,
                });
            }
            return books;
        }
    }
}
