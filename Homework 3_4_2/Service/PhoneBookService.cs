using Homework_3_4_2.Entity;
using Homework_3_4_2.Model;
using Homework_3_4_2.Repository.Abstraction;
using Homework_3_4_2.Service.Abstaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4_2.Service
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly IPhoneBookRepository _phonebookRepository;
        public PhoneBookService(IPhoneBookRepository phonebookRepository)
        { 
            _phonebookRepository = phonebookRepository;
        }
        public List<PhoneBook> GetPhoneBooks()
        {
            var phonebookEntities = _phonebookRepository.GetPhoneBooks();
            var phonebooks = new List<PhoneBook>();

            foreach(var phonebookEntity in phonebookEntities)
            {
                phonebooks.Add(new PhoneBook()
                {
                    FoolName =phonebookEntity.FoolName,
                    Number = phonebookEntity.Number,
                });
            }
            return phonebooks;
        }
    }
}
