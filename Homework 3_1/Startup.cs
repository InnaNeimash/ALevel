using Homework_3_1.Entity;
using Homework_3_1.Model;
using Homework_3_1.Service.Abstaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    internal class Startup
    {
        private readonly IBookService _bookService;

        public Startup(IBookService bookService)
        {
            _bookService = bookService;
        }
        public void Stat()
        {
           GetBook();
           SortByPrice();
           AddNewBook();
        }
        private void GetBook()
        {
            var books = _bookService.GetBooks();
            Console.WriteLine("Your changed books: ");
            foreach (var book in books) 
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine($"Count your changed books {books.Count}");
        }
        private void SortByPrice()
        {
            var books = _bookService.GetBooks();
            books.Sort((x,y) =>x.Price.CompareTo(y.Price));
            Console.WriteLine("Sorted books list");
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        private void AddNewBook()
        {
            var books = _bookService.GetBooks();
            Console.WriteLine("Do you want to agg new book. Please change an action: 1-yes, 2-no");
            int change = Convert.ToInt32(Console.ReadLine());
            if (change == 1)
            {
                books.Insert(4, new Book() { Id = Guid.NewGuid(), Name = "Little women", Author = "Loisa May Alscott", Price = 680 });

                foreach (var book in books)
                {
                    Console.WriteLine(book.ToString());
                }
            }
            Console.WriteLine("Do you want to delete book. Please enter number book");
                int chang = Convert.ToInt32(Console.ReadLine());
                books.RemoveAt(chang);
                foreach (var book in books)
                {
                 Console.WriteLine(book.ToString());
                }
        }
    }
}
