using Homework_3_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1.Service.Abstaction
{
    public interface IBookService
    {
        Guid AddBook(Book book);
        List<Book> GetBooks();
    }
}
