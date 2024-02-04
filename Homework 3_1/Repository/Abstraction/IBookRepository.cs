using Homework_3_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1.Repository.Abstraction
{
    public interface IBookRepository
    {
        Guid AddBook(BookEntity book);
        List<BookEntity>GetBooks();
    }
}
