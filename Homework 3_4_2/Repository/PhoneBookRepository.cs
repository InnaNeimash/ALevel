using Homework_3_4_2.Entity;
using Homework_3_4_2.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4_2.Repository
{
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private List<PhoneBookEntity> phonebooks = new List<PhoneBookEntity>();
        public PhoneBookRepository()
        {
            phonebooks = new List<PhoneBookEntity>()
            {
                new PhoneBookEntity()
                {
                    FoolName = "Tulsky Dmitro",
                    Number = "380978549851",
                },
                new PhoneBookEntity()
                {
                    FoolName = "Yakovenko Anna",
                    Number = "380963458754"
                },
                new PhoneBookEntity()
                {
                    FoolName = "Snishko Nikita",
                    Number = "412586987102"
                },
                new PhoneBookEntity()
                {
                    FoolName = "Шмиря Олена",
                    Number = "380975841245"
                },
                new PhoneBookEntity()
                {
                    FoolName = "Соколов Максим",
                    Number = "380931254787"
                },
                new PhoneBookEntity()
                {
                    FoolName = "-",
                    Number = "380632541745"
                },
                new PhoneBookEntity()
                {
                    FoolName = "-",
                    Number = "380972511515"
                },
                new PhoneBookEntity()
                {
                    FoolName = "",
                    Number = "?380972511515"
                },
                new PhoneBookEntity()
                {
                    FoolName = "",
                    Number = "_38097215"
                },
                new PhoneBookEntity()
                {
                    FoolName = "",
                    Number = "#111"
                }

            };
        }
        public List<PhoneBookEntity> GetPhoneBooks()
        {
            return phonebooks;
        }
    }
}
