using Homework_3_4_2.Model;
using Homework_3_4_2.Service.Abstaction;
using System.Linq;

namespace Homework_3_4_2
{
    internal class Startup
    {
        private readonly IPhoneBookService _phonebookService;
        public Startup(IPhoneBookService phonebookService)
        {
            _phonebookService = phonebookService;
        }
        public void Stat()
        {
            GetPhoneBook();
            SortByCulture();
        }
        private void GetPhoneBook()
        {
            var phonebooks = _phonebookService.GetPhoneBooks();
            Console.WriteLine("Your phonebook: ");
            foreach (var phonebook in phonebooks)
            {
                Console.WriteLine(phonebook.ToString());
            }
        }
        private void SortByCulture()
        {
            var phonebooks = _phonebookService.GetPhoneBooks();
            var firstphonebook = phonebooks.FirstOrDefault();
            var filterphonebook = phonebooks.Where(c => c.FoolName.Contains("a")).ToList();
            var phonebookLengths = phonebooks.Select(c => c.FoolName.Length).ToList();
            var phonebooksort = phonebooks.OrderBy(c => c.Number).ToList();
            var lowergrades = phonebooks.OrderByDescending(c => c.Number).Skip(3);
                        
            Console.WriteLine("First contact: " + firstphonebook);
            Console.WriteLine("Filtered contacts containing 'a' : " + string.Join(",", filterphonebook));
            Console.WriteLine("Length fool name of each contact: " + string.Join(",", phonebookLengths));
            Console.WriteLine("Sorted phonebbok: " + string.Join(",", phonebooksort));
            Console.WriteLine("Contact with the longest fool name: " + phonebooks.MaxBy(c =>c.FoolName));
            Console.WriteLine("All grades except the top three are: " + string.Join(",", lowergrades));
        }
    }
}

                
                        
                    
                    
                



                  

                    


                  
                
           
           
        
                
               
