using Homework_3_4_2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4_2.Repository.Abstraction
{
    public interface IPhoneBookRepository
    {
       List<PhoneBookEntity>GetPhoneBooks();
    }
}
