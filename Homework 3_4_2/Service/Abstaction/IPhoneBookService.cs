using Homework_3_4_2.Entity;
using Homework_3_4_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4_2.Service.Abstaction
{
    public interface IPhoneBookService
    {
        List<PhoneBook> GetPhoneBooks();
    }
}
